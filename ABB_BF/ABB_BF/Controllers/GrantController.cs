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
    public class GrantController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGrantService _grantService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IFileHelper _fileHelper;
        private readonly IEmailSenderService _emailService;
        private readonly IEnumsToEntitiesService _enumsToEntitiesService;
        private readonly ICollegeService _collegeService;

        private static readonly string _emailToEnvVarName = "EMAIL_TO";
        private readonly string _emailTo = Environment.GetEnvironmentVariable(_emailToEnvVarName);

        public GrantController(
            IEmailSenderService emailService, 
            IMapper mapper, 
            IFileHelper fileHelper, 
            IGrantService grantService, 
            IWebHostEnvironment appEnvironment, 
            IEnumsToEntitiesService enumsToEntitiesService,
            ICollegeService collegeService)
        {
            _mapper = mapper;
            _grantService = grantService;
            _appEnvironment = appEnvironment;
            _fileHelper = fileHelper;
            _emailService = emailService;
            _enumsToEntitiesService = enumsToEntitiesService;
            _collegeService = collegeService;

        }

        [HttpPost]
        public async Task<ActionResult<int>> AddGrant([FromForm] AddGrantRequest grantRequest)
        {
            GrantModel model = _mapper.Map<GrantModel>(grantRequest);

            model.EducationForm = await _enumsToEntitiesService.GetDefinitionByNumberFromEducationForms(grantRequest.EducationForm);
            model.EducationLevel = await _enumsToEntitiesService.GetDefinitionByNumberFromEducationLevels(grantRequest.EducationLevel);
            model.Speciality = await _enumsToEntitiesService.GetDefinitionByNumberFromSpecialities(grantRequest.Speciality);

            return Ok(await _grantService.AddGrant(model));
        }

        [HttpGet("download")]
        public async Task<ActionResult> DownloadCsv(
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

            FilterModel filter = _mapper.Map<FilterModel>(filters);

            CollegeModel? college = await _collegeService.GetCollegeById(Convert.ToInt32(filters.College));

            if (college is not null)
            {
                filter.College = college.Name;
            }

            string fileName = 
                _fileHelper.CreateFileNmae(filter, "Стипендия");

            string name = await _grantService.CreateXlsx(filter, fileName);

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
            FilterModel filter = _mapper.Map<FilterModel>(filters);

            CollegeModel? college = await _collegeService.GetCollegeById(Convert.ToInt32(filters.College));

            if (college is not null)
            {
                filter.College = college.Name;
            }

            string fileName =
                _fileHelper.CreateFileNmae(filter, "Стипендия");

            string name = await _grantService.CreateXlsx(filter, fileName);

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
