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
        private readonly IFileHelper _csvHelper;
        private readonly IPracticeRepository _practiceRepository;

        public PracticeService(IMapper mapper, IPracticeRepository practiceRepository, IFileHelper csvHelper)
        {
            _mapper = mapper;
            _practiceRepository = practiceRepository;
            _csvHelper = csvHelper;
        }

        public async Task<int> AddPractice(PracticeModel practiceModel)
        {
            Practice practice = _mapper.Map<Practice>(practiceModel);

            return await _practiceRepository.AddPractice(practice);
        }

        public async Task<string> CreateCsv()
        {
            return await _csvHelper.GetScv(await _practiceRepository.GetAll());
        }

        public async Task<List<PracticeModel>> GetAll()
        {
            return _mapper.Map<List<PracticeModel>>(await _practiceRepository.GetAll());
        }
    }
}