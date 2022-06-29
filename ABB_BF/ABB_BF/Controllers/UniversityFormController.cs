using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class UniversityFormController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUniversityFormService _universityFormService;
        public UniversityFormController(IMapper mapper, IUniversityFormService universityFormService)
        {
            _mapper = mapper;
            _universityFormService = universityFormService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddUniversityForm([FromBody] AddUniversityFormRequest form)
        {
            int id = await _universityFormService
                .AddUniversityForm(_mapper.Map<UniversityFormModel>(form));
            return Ok(id);
        }
    }
}
