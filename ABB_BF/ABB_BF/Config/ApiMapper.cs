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
            CreateMap<AddUniversityRequest, UniversityModel>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => DateOnly.FromDateTime(src.StartDate)));
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
                .AddTransform<string>(s => string.IsNullOrEmpty(s) ? null : s)
                .ForMember(dest => dest.StartInterval, opt => opt
                    .MapFrom(src => string.IsNullOrEmpty(src.StartInterval) ? DateTime.MinValue : DateTime.Parse(src.StartInterval)))
                .ForMember(dest => dest.FinishInterval, opt => opt
                    .MapFrom(src => string.IsNullOrEmpty(src.FinishInterval) ? DateTime.MaxValue : DateTime.Parse(src.FinishInterval)))
                .ForMember(dest => dest.CourseDirections, opt => opt.Ignore())
                .ForMember(dest => dest.College, opt => opt.Ignore());

            CreateMap<CollegeModel, CollegeResponse>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));
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
