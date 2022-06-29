using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
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

        public PracticeController(IMapper mapper, IPracticeService practiceService)
        {
            _mapper = mapper;
            _practiceService = practiceService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddPractice([FromBody] AddPracticeRequest practiceRequest)
        {
            PracticeModel model = _mapper.Map<PracticeModel>(practiceRequest);

            return Ok(await _practiceService.AddPractice(model));
        }
    }
}
