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
        private readonly IModelsService _modelsService;

        public PracticeService(IMapper mapper, 
            IPracticeRepository practiceRepository, 
            IFileHelper csvHelper,
            IModelsService modelsService)
        {
            _mapper = mapper;
            _practiceRepository = practiceRepository;
            _csvHelper = csvHelper;
            _modelsService = modelsService;
        }

        public async Task<int> AddPractice(PracticeModel practiceModel)
        {
            if (!_modelsService.IsNumberValid(practiceModel.Phone))
            {
                throw new ArgumentException("Введен неверный номер");
            }
            else if (!_modelsService.IsEmailValid(practiceModel.Email))
            {
                throw new ArgumentException("Введен неверный e-mail");
            }

            practiceModel.Phone = _modelsService.FixPhoneNumber(practiceModel.Phone);

            return await _practiceRepository.AddPractice(_mapper.Map<Practice>(practiceModel));
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