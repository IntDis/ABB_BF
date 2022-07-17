using ABB_BF.API.Models.Requests;
using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Enums;
using ABB_BF.Models.Requests;
using ABB_BF.Models.Responses;
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

        private static readonly string _emailToEnvVarName = "EMAIL_TO";
        private readonly string _emailTo = Environment.GetEnvironmentVariable(_emailToEnvVarName);

        public UniversityController(
            IMapper mapper,
            IUniversityService universityService,
            IWebHostEnvironment appEnvironment,
            IFileHelper fileHelper,
            IEmailSenderService emailService,
            IEnumsToEntitiesService enumsToEntitiesService)
        {
            _mapper = mapper;
            _universityService = universityService;
            _appEnvironment = appEnvironment;
            _fileHelper = fileHelper;
            _emailService = emailService;
            _enumsToEntitiesService = enumsToEntitiesService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddUniversityForm([FromForm] AddUniversityRequest form)
        {
            UniversityModel model = _mapper.Map<UniversityModel>(form);

            model.Direction = await _enumsToEntitiesService.GetDefinitionByNumberFromCourseDirections(form.Direction);

            return Ok(await _universityService.AddUniversityForm(model));
        }

        [HttpGet("download")]
        public async Task<ActionResult> DownloadCsv(
            [FromHeader] bool? IsChecked,
            [FromHeader] string? StartInterval,
            [FromHeader] string? FinishInterval,
            [FromHeader] string? College,
            [FromHeader] int? Course,
            [FromHeader] int? CourseDirections)
        {
            FilterRequest filters = new FilterRequest()
            {
                IsChecked = IsChecked,
                StartInterval = StartInterval,
                FinishInterval = FinishInterval,
                College = College,
                Course = Course,
                CourseDirections = CourseDirections
            };

            string courseDirection =
                await _enumsToEntitiesService.GetDefinitionByNumberFromCourseDirections(filters.CourseDirections);

            FilterModel filter = _mapper.Map<FilterModel>(filters);

            filter.CourseDirections = courseDirection;

            string fileName =
                _fileHelper.CreateFileNmae(filter, "Курсы", courseDirection);

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
            [FromHeader] int? CourseDirections
            )
        {
            FilterRequest filters = new FilterRequest()
            {
                IsChecked = IsChecked,
                StartInterval = StartInterval,
                FinishInterval = FinishInterval,
                College = College,
                Course = Course,
                CourseDirections = CourseDirections
            };

            string courseDirection =
                await _enumsToEntitiesService.GetDefinitionByNumberFromCourseDirections(filters.CourseDirections);

            FilterModel filter = _mapper.Map<FilterModel>(filters);

            filter.CourseDirections = courseDirection;

            string fileName =
                _fileHelper.CreateFileNmae(filter, "Курсы", courseDirection);

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
    }
}
