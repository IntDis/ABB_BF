using ABB_BF.API.Models.Requests;
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
            CreateMap<AddProbationRequest, ProbationModel>();
            CreateMap<AddGrantRequest, GrantModel>();
            CreateMap<AddUniversityRequest, UniversityModel>();
            CreateMap<AddPracticeRequest, PracticeModel>();


            CreateMap<UniversityModel, UniversityResponse>();
            CreateMap<GrantModel, GrantResponse>();
            CreateMap<PracticeModel, PracticeResponse>();
            CreateMap<ProbationModel, ProbationResponse>();

            CreateMap<ProbationModel, AbstractEntityModel>();

            CreateMap<IFormFile, AbstractFormFileModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FileName))
                .ForMember(dest => dest.Extension, opt => opt.MapFrom(src => GetExtension(src.FileName)))
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => GetBytes(src)));

            CreateMap<FilterRequest, FilterModel>()
                .ForMember(dest => dest.StartInterval, opt => opt.NullSubstitute(DateTime.MinValue))
                .ForMember(dest => dest.FinishInterval, opt => opt.NullSubstitute(DateTime.MaxValue));
        }

        protected string GetExtension(string fileName)
        {
            return fileName.Split('.')[fileName.Split('.').Length - 1];
        }

        protected byte[] GetBytes(IFormFile file)
        {
            var binaryReader = new BinaryReader(file.OpenReadStream());
            return binaryReader.ReadBytes((int)file.Length);
        }
    }
}
