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
            CreateMap<UniversityForm, UniversityFormModel>().ReverseMap();
        }
    }
}
