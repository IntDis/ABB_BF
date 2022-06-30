using ABB_BF.API.Models.Responses;
using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class ProbationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProbationService _probationService;
        private readonly IWebHostEnvironment _appEnvironment;

        public ProbationController(IMapper mapper,
            IProbationService probationService,
            IWebHostEnvironment appEnvironment)
        {
            _mapper = mapper;
            _probationService = probationService;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddProbation([FromBody] AddProbationRequest requestModel)
        {
            int id = await _probationService.AddProbation(_mapper.Map<ProbationModel>(requestModel));
            return Ok(id);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProbationResponse>>> GetAll()
        {
            return Ok(_mapper.Map<List<ProbationResponse>>(await _probationService.GetAll()));
        }

        [HttpGet("csv")]
        public async Task<ActionResult> DownloadCsv()
        {
            string fileName = await _probationService.CreateCsv();

            string fileType = "application/csv";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, fileName);

            return PhysicalFile(filePath, fileType, fileName);
        }
    }
}
