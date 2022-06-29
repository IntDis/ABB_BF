using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class PracticeService : IPracticeService
    {
        private readonly IMapper _mapper;
        private readonly IPracticeRepository _practiceRepository;

        public PracticeService(IMapper mapper, IPracticeRepository practiceRepository)
        {
            _mapper = mapper;
            _practiceRepository = practiceRepository;
        }

        public async Task<int> AddPractice(PracticeModel practiceModel)
        {
            Practice practice = _mapper.Map<Practice>(practiceModel);

            return await _practiceRepository.AddPractice(practice);
        }
    }
}