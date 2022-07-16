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

        public GrantController(IEmailSenderService emailService, IMapper mapper, IFileHelper fileHelper, IGrantService grantService, IWebHostEnvironment appEnvironment)
        {
            _mapper = mapper;
            _grantService = grantService;
            _appEnvironment = appEnvironment;
            _fileHelper = fileHelper;
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddGrant([FromForm] AddGrantRequest grantRequest)
        {
            GrantModel model = _mapper.Map<GrantModel>(grantRequest);
            return Ok(await _grantService.AddGrant(model));
        }

        [HttpGet("download")]
        public async Task<ActionResult> DownloadCsv(
            [FromHeader] string fileName,
            [FromHeader] bool? IsChecked,
            [FromHeader] string? StartInterval,
            [FromHeader] string? FinishInterval,
            [FromHeader] string? College,
            [FromHeader] int? Course,
            [FromHeader] CourseDirections? CourseDirections
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

            string name = await _grantService.CreateXlsx(_mapper.Map<FilterModel>(filters), fileName);

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
            [FromHeader] string fileName,
            [FromHeader] bool? IsChecked,
            [FromHeader] string? StartInterval,
            [FromHeader] string? FinishInterval,
            [FromHeader] string? College,
            [FromHeader] int? Course,
            [FromHeader] CourseDirections? CourseDirections
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

            string name = await _grantService.CreateXlsx(_mapper.Map<FilterModel>(filters), fileName);

            string fileType = "application/zip";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, name);

            string zipPath = await _fileHelper.CreateZip(filePath, $"{filePath}.zip");

            FileStream fs = new FileStream(zipPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);

            _emailService
                .SendMessage("azarovrom9215@gmail.com", "Привет, тема пока такая", new Attachment(fs, $"{fileName}.zip"));

            return Ok();
        }
    }
}
