using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class ProbationService : IProbationService
    {
        private readonly IMapper _mapper;
        private readonly IProbationRepository _probationRepository;
        private readonly IFileHelper _csvHelper;
        private readonly IModelsService _modelsService;

        public ProbationService(IMapper mapper,
            IProbationRepository probationRepository,
            IFileHelper csvHelper,
            IModelsService modelsService)
        {
            _mapper = mapper;
            _probationRepository = probationRepository;
            _csvHelper = csvHelper;
            _modelsService = modelsService;
        }

        public async Task<int> AddProbation(ProbationModel probationModel)
        {
            if (!_modelsService.IsNumberValid(probationModel.Phone))
            {
                throw new ArgumentException("Введен неверный номер");
            }
            else if (!_modelsService.IsEmailValid(probationModel.Email))
            {
                throw new ArgumentException("Введен неверный e-mail");
            }

            probationModel.Phone = _modelsService.FixPhoneNumber(probationModel.Phone);
            
            return await _probationRepository.AddProbation(_mapper.Map<Probation>(probationModel));
        }

        public async Task<List<ProbationModel>> GetAll(FilterModel filter)
        {
            return _mapper.Map<List<ProbationModel>>(await _probationRepository.GetAll(_mapper.Map<Filter>(filter)));
        }

        public async Task<string> CreateCsv(FilterModel filter)
        {
            return await _csvHelper.GetScv(await _probationRepository.GetAll(_mapper.Map<Filter>(filter)));
        }
    }
}