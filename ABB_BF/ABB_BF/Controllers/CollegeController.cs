using ABB_BF.API.Models.Responses;
using ABB_BF.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.API.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CollegeController : Controller
    {
        private readonly ICollegeService _collegeService;

        public CollegeController(ICollegeService collegeService)
        {
            _collegeService = collegeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CollegeResponse>>> GetAll()
        {
            List<string> colleges = await _collegeService.GetAllColleges();
            List<CollegeResponse> collegesResponse = new List<CollegeResponse>();

            foreach(string str in colleges)
            {
                CollegeResponse college = new CollegeResponse()
                {
                    Id = str,
                    Text = str
                };

                collegesResponse.Add(college);
            }

            return Ok(collegesResponse);
        }
    }
}
