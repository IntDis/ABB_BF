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

        public ProbationController(IMapper mapper, IProbationService probationService)
        {
            _mapper = mapper;
            _probationService = probationService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddProbation([FromBody] AddProbationRequest requestModel)
        {
            int id = await _probationService.AddProbation(_mapper.Map<ProbationModel>(requestModel));
            return Ok(id);
        }
    }
}
