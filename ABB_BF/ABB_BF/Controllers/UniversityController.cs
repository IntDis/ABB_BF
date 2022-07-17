using ABB_BF.API.Models.Requests;
using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class UniversityController : Controller
    {
        private readonly IUniversityService _universityService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IMapper _mapper;
        private readonly IFileHelper _fileHelper;
        private readonly IEmailSenderService _emailService; 
        private readonly IEnumsToEntitiesService _enumsToEntitiesService;
        private readonly ICollegeService _collegeService;

        private static readonly string _emailToEnvVarName = "EMAIL_TO";
        private readonly string _emailTo = Environment.GetEnvironmentVariable(_emailToEnvVarName);

        public UniversityController(
            IMapper mapper,
            IUniversityService universityService,
            IWebHostEnvironment appEnvironment,
            IFileHelper fileHelper,
            IEmailSenderService emailService,
            IEnumsToEntitiesService enumsToEntitiesService,
            ICollegeService collegeService)
        {
            _mapper = mapper;
            _universityService = universityService;
            _appEnvironment = appEnvironment;
            _fileHelper = fileHelper;
            _emailService = emailService;
            _enumsToEntitiesService = enumsToEntitiesService;
            _collegeService = collegeService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddUniversityForm([FromForm] AddUniversityRequest form)
        {
            UniversityModel model = _mapper.Map<UniversityModel>(form);

            model.CourseDirection = 
                await _enumsToEntitiesService.GetDefinitionByNumberFromCourseDirections(form.CourseDirection);

            int collegeId;
            if (int.TryParse(form.College, out collegeId))
            {
                model.College = (await _collegeService.GetCollegeById(collegeId)).Name;
            }

            return Ok(await _universityService.AddUniversityForm(model));
        }

        [HttpGet("download")]
        public async Task<ActionResult> DownloadCsv(
            [FromHeader] bool? IsChecked,
            [FromHeader] string? StartInterval,
            [FromHeader] string? FinishInterval,
            [FromHeader] string? College,
            [FromHeader] int? Course,
            [FromHeader] int? CourseDirection)
        {
            FilterRequest filters = new FilterRequest()
            {
                IsChecked = IsChecked,
                StartInterval = StartInterval,
                FinishInterval = FinishInterval,
                College = College,
                Course = Course,
                CourseDirections = CourseDirection
            };

            FilterModel filter = await CombineFilter(filters);

            string fileName =
                _fileHelper.CreateFileNmae(filter, "Курсы", filter.CourseDirections);

            string name = await _universityService.CreateXlsx(filter, fileName);

            string fileType = "application/zip";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, name);

            string zipPath = await _fileHelper.CreateZip(filePath, $"{filePath}.zip");

            FileStream fs = new FileStream(zipPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);

            return File(
                fileStream: fs,
                contentType: fileType,
                fileDownloadName: $"{fileName}.zip");
        }

        [HttpGet("send")]
        public async Task<ActionResult> SendEmail(
            [FromHeader] bool? IsChecked,
            [FromHeader] string? StartInterval,
            [FromHeader] string? FinishInterval,
            [FromHeader] string? College,
            [FromHeader] int? Course,
            [FromHeader] int? CourseDirection
            )
        {
            FilterRequest filters = new FilterRequest()
            {
                IsChecked = IsChecked,
                StartInterval = StartInterval,
                FinishInterval = FinishInterval,
                College = College,
                Course = Course,
                CourseDirections = CourseDirection
            };

            FilterModel filter = await CombineFilter(filters);

            string fileName =
                _fileHelper.CreateFileNmae(filter, "Курсы");

            string name = await _universityService.CreateXlsx(filter, fileName);

            string filePath = Path.Combine(_appEnvironment.ContentRootPath, name);
            string zipPath = await _fileHelper.CreateZip(filePath, $"{filePath}.zip");

            FileStream fs = new FileStream(zipPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);

            _emailService
                .SendMessage(_emailTo, fileName, new Attachment(fs, $"{fileName}.zip"));

            fs.Close();
            System.IO.File.Delete(zipPath);

            return Ok();
        }

        private async Task<FilterModel> CombineFilter(FilterRequest filters)
        {
            FilterModel filter = _mapper.Map<FilterModel>(filters);
            if (filters.CourseDirections != null)
            {
                filter.CourseDirections = 
                    await _enumsToEntitiesService.GetDefinitionByNumberFromCourseDirections(filters.CourseDirections);
            }

            CollegeModel? college = await _collegeService.GetCollegeById(Convert.ToInt32(filters.College));

            if (college is not null)
            {
                filter.College = college.Name;
            }

            return filter;
        }
    }
}
