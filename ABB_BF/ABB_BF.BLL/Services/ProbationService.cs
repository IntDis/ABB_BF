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
        private readonly ICsvHelper _csvHelper;

        public ProbationService(IMapper mapper,
            IProbationRepository probationRepository,
            ICsvHelper csvHelper)
        {
            _mapper = mapper;
            _probationRepository = probationRepository;
            _csvHelper = csvHelper;
        }

        public async Task<int> AddProbation(ProbationModel probationModel)
        {
            return await _probationRepository.AddProbation(_mapper.Map<Probation>(probationModel));
        }

        public async Task<List<ProbationModel>> GetAll()
        {
            return _mapper.Map<List<ProbationModel>>(await _probationRepository.GetAll());
        }

        public async Task<string> CreateCsv()
        {
            return await _csvHelper.GetScv(await _probationRepository.GetAll());
        }
    }
}