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

        public ProbationService(IMapper mapper,
            IProbationRepository probationRepository,
            IFileHelper csvHelper)
        {
            _mapper = mapper;
            _probationRepository = probationRepository;
            _csvHelper = csvHelper;
        }

        public async Task<int> AddProbation(ProbationModel probationModel)
        {
            probationModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);

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