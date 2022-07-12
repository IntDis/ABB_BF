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
    public class UniversityFormController : Controller
    {
        private readonly IUniversityService _universityFormService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IMapper _mapper;

        public UniversityFormController(
            IMapper mapper,
            IUniversityService universityFormService,
            IWebHostEnvironment appEnvironment)
        {
            _mapper = mapper;
            _universityFormService = universityFormService;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddUniversityForm([FromBody] AddUniversityRequest form)
        {
            UniversityModel model = _mapper.Map<UniversityModel>(form);
            return Ok(await _universityFormService.AddUniversityForm(model));
        }

        [HttpGet]
        public async Task<ActionResult<List<UniversityResponse>>> GetAll()
        {
            return Ok(_mapper
                .Map<List<UniversityResponse>> (await _universityFormService.GetAll()));
        }

        [HttpGet("csv")]
        public async Task<ActionResult> DownloadCsv()
        {
            string fileName = await _universityFormService.CreateCsv();

            string fileType = "application/csv";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, fileName);

            return PhysicalFile(filePath, fileType, fileName);
        }
    }
}
