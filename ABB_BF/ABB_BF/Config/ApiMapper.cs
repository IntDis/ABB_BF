using ABB_BF.BLL.Models;
using ABB_BF.Models.Requests;
using AutoMapper;

namespace ABB_BF.Config
{
    public class ApiMapper : Profile
    {
        public ApiMapper()
        {
            CreateMap<AddProbationRequest, ProbationModel>();
            CreateMap<AddGrantRequest, GrantModel>();
            CreateMap<AddPracticeRequest, PracticeModel>();
        }
    }
}
