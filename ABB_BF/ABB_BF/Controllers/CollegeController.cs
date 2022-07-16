using ABB_BF.API.Models.Responses;
using ABB_BF.BLL.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.API.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CollegeController : Controller
    {
        private readonly ICollegeService _collegeService;
        private readonly IMapper _mapper;

        public CollegeController(
            ICollegeService collegeService,
            IMapper mapper)
        {
            _collegeService = collegeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CollegeResponse>>> GetAll()
        {
            List<CollegeResponse> colleges = 
                _mapper.Map<List<CollegeResponse>>(await _collegeService.GetAllColleges());

            return Ok(colleges);
        }
    }
}
