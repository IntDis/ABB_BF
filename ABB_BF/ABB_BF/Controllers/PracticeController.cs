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
    public class PracticeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPracticeService _practiceService;
        private readonly IWebHostEnvironment _appEnvironment;


        public PracticeController(IMapper mapper, IPracticeService practiceService, IWebHostEnvironment appEnvironment)
        {
            _mapper = mapper;
            _practiceService = practiceService;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddPractice([FromBody] AddPracticeRequest practiceRequest)
        {
            PracticeModel model = _mapper.Map<PracticeModel>(practiceRequest);
            return Ok(await _practiceService.AddPractice(model));
        }

        [HttpGet]
        public async Task<ActionResult<List<PracticeResponse>>> GetAll()
        {
            return Ok(_mapper.Map<List<PracticeResponse>>(await _practiceService.GetAll()));
        }

        [HttpGet("csv")]
        public async Task<ActionResult> DownloadCsv()
        {
            string fileName = await _practiceService.CreateCsv();

            string fileType = "application/csv";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, fileName);

            return PhysicalFile(filePath, fileType, fileName);
        }
    }
}
