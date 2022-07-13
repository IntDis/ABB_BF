using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
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

            probationModel.Phone = _modelsService.FixPhoneNumber(probationModel.Phone);
            
            return await _probationRepository.AddProbation(_mapper.Map<Probation>(probationModel));
        }

        public async Task<List<ProbationModel>> GetAll()
        {
            return _mapper.Map<List<ProbationModel>>(await _probationRepository.GetAll());
        }

        public async Task<ProbationModel> GetById(int id)
        {
            return _mapper.Map<ProbationModel>(await _probationRepository.GetById(id));
        }

        public async Task<string> CreateCsv()
        {
            return await _csvHelper.GetScv(await _probationRepository.GetAll());
        }
    }
}