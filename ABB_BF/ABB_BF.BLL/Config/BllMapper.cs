using ABB_BF.BLL.Models;
using ABB_BF.DAL.Entities;
using AutoMapper;

namespace ABB_BF.BLL.Config
{
    public class BllMapper : Profile
    {
        public BllMapper()
        {
            CreateMap<Probation, ProbationModel>().ReverseMap();
            CreateMap<Grant, GrantModel>().ReverseMap();
            CreateMap<University, UniversityModel>().ReverseMap();
            CreateMap<Practice, PracticeModel>().ReverseMap();

            CreateMap<ProbationFileModel, ProbationFile>().ReverseMap();
            CreateMap<AbstractFormFileModel, ProbationFile>().ReverseMap();

            CreateMap<GrantFileModel, GrantFiles>().ReverseMap();
            CreateMap<AbstractFormFileModel, GrantFiles>().ReverseMap();

            CreateMap<PracticeFileModel, PracticeFile>().ReverseMap();
            CreateMap<AbstractFormFileModel, PracticeFile>().ReverseMap();

            CreateMap<UniversityFileModel, UniversityFile>().ReverseMap();
            CreateMap<AbstractFormFileModel, UniversityFile>().ReverseMap();

            CreateMap<AbstractFormFileModel, AbstractFormFile>().ReverseMap();
            CreateMap<AbstractEntityModel, AbstractCommonData>().ReverseMap();
        }
    }
}
