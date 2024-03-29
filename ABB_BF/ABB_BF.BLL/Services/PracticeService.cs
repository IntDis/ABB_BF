﻿using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class PracticeService : IPracticeService
    {
        private readonly IMapper _mapper;
        private readonly IFileHelper _fileHelper;
        private readonly IPracticeRepository _practiceRepository;

        public PracticeService(IMapper mapper, IPracticeRepository practiceRepository, IFileHelper fileHelper)
        {
            _mapper = mapper;
            _practiceRepository = practiceRepository;
            _fileHelper = fileHelper;
        }

        public async Task<int> AddPractice(PracticeModel practiceModel)
        {
            practiceModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);


            Practice practice = _mapper.Map<Practice>(practiceModel);

            return await _practiceRepository.AddPractice(practice);
        }

        public async Task<List<PracticeModel>> GetAll(FilterModel filter)
        {
            return _mapper.Map<List<PracticeModel>>(await _practiceRepository.GetAll(_mapper.Map<Filter>(filter)));
        }
    }
}