﻿using ABB_BF.BLL.Models;
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
            CreateMap<AddUniversityFormRequest, UniversityFormModel>();
            CreateMap<AddPracticeRequest, PracticeModel>();

            CreateMap<UniversityFormModel, UniversityFormResponse>();
            CreateMap<GrantModel, GrantFormResponse>();
            CreateMap<PracticeModel, PracticeResponse>();
        }
    }
}
