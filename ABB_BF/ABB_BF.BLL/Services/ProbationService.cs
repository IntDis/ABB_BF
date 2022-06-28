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

        public ProbationService(IMapper mapper, IProbationRepository probationRepository)
        {
            _mapper = mapper;
            _probationRepository = probationRepository;
        }

        public async Task<int> AddProbation(ProbationModel model)
        {
            return await _probationRepository.AddProbation(_mapper.Map<Probation>(model));
        }
    }
}
