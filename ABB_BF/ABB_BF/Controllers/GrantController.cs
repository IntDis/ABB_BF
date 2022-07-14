using ABB_BF.API.Models.Requests;
using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Enums;
using ABB_BF.Models.Requests;
using ABB_BF.Models.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class GrantController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGrantService _grantService;
        private readonly IWebHostEnvironment _appEnvironment;

        public GrantController(IMapper mapper, IGrantService grantService, IWebHostEnvironment appEnvironment)
        {
            _mapper = mapper;
            _grantService = grantService;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddGrant([FromBody] AddGrantRequest grantRequest)
        {
            GrantModel model = _mapper.Map<GrantModel>(grantRequest);
            return Ok(await _grantService.AddGrant(model));
        }

        [HttpGet("csv")]
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

            string name = await _grantService.CreateCsv(_mapper.Map<FilterModel>(filters));

            string fileType = "application/csv";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, name);

            FileStream fs = new FileStream(filePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);

            return File(
                fileStream: fs,
                contentType: fileType,
                fileDownloadName: $"{fileName}.xlsx");
        }
    }
}
