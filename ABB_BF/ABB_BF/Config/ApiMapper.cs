using ABB_BF.API.Models.Responses;
using ABB_BF.BLL.Models;
using ABB_BF.Models.Requests;
using ABB_BF.Models.Responses;
using AutoMapper;

namespace ABB_BF.Config
{
    public class ApiMapper : Profile
    {
        public ApiMapper()
        {
            CreateMap<AddProbationRequest, ProbationModel>()
                .ForMember(dest => dest.Files, (options) => options.Ignore());

            CreateMap<AddGrantRequest, GrantModel>()
                .ForMember(dest => dest.Files, (options) => options.Ignore());

            CreateMap<AddUniversityFormRequest, UniversityFormModel>()
                .ForMember(dest => dest.Files, (options) => options.Ignore());

            CreateMap<AddPracticeRequest, PracticeModel>()
                .ForMember(dest => dest.Files, (options) => options.Ignore());


            CreateMap<UniversityFormModel, UniversityFormResponse>();
            CreateMap<GrantModel, GrantFormResponse>();
            CreateMap<PracticeModel, PracticeResponse>();
            CreateMap<ProbationModel, ProbationResponse>();
        }
    }
}
