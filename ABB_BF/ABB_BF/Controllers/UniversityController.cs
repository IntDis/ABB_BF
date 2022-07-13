using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
using ABB_BF.Models.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class UniversityController : Controller
    {
        private readonly IUniversityService _universityService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IMapper _mapper;

        public UniversityController(
            IMapper mapper,
            IUniversityService universityService,
            IWebHostEnvironment appEnvironment)
        {
            _mapper = mapper;
            _universityService = universityService;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddUniversityForm([FromBody] AddUniversityRequest form)
        {
            UniversityModel model = _mapper.Map<UniversityModel>(form);
            return Ok(await _universityService.AddUniversityForm(model));
        }

        [HttpGet]
        public async Task<ActionResult<List<UniversityResponse>>> GetAll()
        {
            return Ok(_mapper
                .Map<List<UniversityResponse>> (await _universityService.GetAll()));
        }

        [HttpGet("csv")]
        public async Task<ActionResult> DownloadCsv()
        {
            string fileName = await _universityService.CreateCsv();

            string fileType = "application/csv";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, fileName);

            string trimmed = Path.GetDirectoryName(filePath);

            FileStream fs = new FileStream(filePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);

            return File(
                fileStream: fs,
                contentType: fileType,
                fileDownloadName: "File.xlsx");
        }
    }
}
