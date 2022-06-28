using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
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

        public GrantController(IMapper mapper, IGrantService grantService)
        {
            _mapper = mapper;
            _grantService = grantService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddGrant([FromBody] AddGrantRequest grantRequest)
        {
            GrantModel model = _mapper.Map<GrantModel>(grantRequest);
            
            return Ok(await _grantService.AddGrant(model));
        }
    }
}
