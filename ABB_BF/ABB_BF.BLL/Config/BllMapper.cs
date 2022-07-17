using ABB_BF.BLL.Models;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using AutoMapper;
using System.Text;

namespace ABB_BF.BLL.Config
{
    public class BllMapper : Profile
    {
        public BllMapper()
        {
            CreateMap<Probation, ProbationModel>().ReverseMap()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Trim().ToLower()))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => FixPhoneNumber(src.Phone.Trim().ToLower())))
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => FirstUpper(src.Firstname.Trim())))
                .ForMember(dest => dest.Secondname, opt => opt.MapFrom(src => FirstUpper(src.Secondname.Trim())))
                .ForMember(dest => dest.Patronymic, opt => opt.MapFrom(src => FirstUpper(src.Patronymic.Trim())));

            CreateMap<Grant, GrantModel>().ReverseMap()
                .ForMember(dest => dest.College, opt => opt.MapFrom(src => src.College.Trim().ToLower()))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Trim().ToLower()))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => FixPhoneNumber(src.Phone.Trim().ToLower())))
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => FirstUpper(src.Firstname.Trim())))
                .ForMember(dest => dest.Secondname, opt => opt.MapFrom(src => FirstUpper(src.Secondname.Trim())))
                .ForMember(dest => dest.Patronymic, opt => opt.MapFrom(src => FirstUpper(src.Patronymic.Trim())));

            CreateMap<University, UniversityModel>().ReverseMap()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Trim().ToLower()))
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => FirstUpper(src.Firstname.Trim())))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => FixPhoneNumber(src.Phone.Trim().ToLower())))
                .ForMember(dest => dest.Secondname, opt => opt.MapFrom(src => FirstUpper(src.Secondname.Trim())))
                .ForMember(dest => dest.Patronymic, opt => opt.MapFrom(src => FirstUpper(src.Patronymic.Trim())))
                .ForMember(dest => dest.Direction, opt => opt.MapFrom(src => FirstUpper(src.CourseDirection.Trim())));

            CreateMap<Practice, PracticeModel>().ReverseMap()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Trim().ToLower()))
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => FirstUpper(src.Firstname.Trim())))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => FixPhoneNumber(src.Phone.Trim().ToLower())))
                .ForMember(dest => dest.Secondname, opt => opt.MapFrom(src => FirstUpper(src.Secondname.Trim())))
                .ForMember(dest => dest.Patronymic, opt => opt.MapFrom(src => FirstUpper(src.Patronymic.Trim())));

            CreateMap<ProbationFileModel, ProbationFile>().ReverseMap();
            CreateMap<AbstractFormFileModel, ProbationFile>().ReverseMap();

            CreateMap<PracticeFileModel, PracticeFile>().ReverseMap();
            CreateMap<AbstractFormFileModel, PracticeFile>().ReverseMap();

            CreateMap<AbstractFormFileModel, AbstractFormFile>().ReverseMap();
            CreateMap<AbstractEntityModel, AbstractCommonData>().ReverseMap();

            CreateMap<FilterModel, Filter>().ReverseMap();
            CreateMap<College, CollegeModel>().ReverseMap()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim().ToLower()));
        }
        private string FirstUpper(string str)
        {
            return str.Substring(0, 1).ToUpper() + (str.Length > 1 ? str.Substring(1) : "").ToLower();
        }

        private string FixPhoneNumber(string number)
        {
            StringBuilder sb = new(number);

            if (sb.ToString().StartsWith("+7"))
            {
                sb.Replace("+7", "8");
            }

            foreach (char symbol in number)
            {
                sb.Replace("(", null);
                sb.Replace("-", null);
                sb.Replace(")", null);
            }

            return sb.ToString();
        }
    }
}