﻿using ABB_BF.API.Models.Responses;
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
                //.ForMember(dest => dest.Files, opt => opt.NullSubstitute(new List<ProbationFileModel>()));

            CreateMap<AddGrantRequest, GrantModel>();
            CreateMap<AddUniversityFormRequest, UniversityFormModel>();
            CreateMap<AddPracticeRequest, PracticeModel>();

            CreateMap<UniversityFormModel, UniversityFormResponse>();
            CreateMap<GrantModel, GrantFormResponse>();
            CreateMap<PracticeModel, PracticeResponse>();
            CreateMap<ProbationModel, ProbationResponse>();
        }
    }
}
