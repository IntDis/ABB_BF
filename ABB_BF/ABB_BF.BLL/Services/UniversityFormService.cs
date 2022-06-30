using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class UniversityFormService : IUniversityFormService
    {
        private readonly IMapper _mapper;
        private readonly ICsvHelper _csvHelper;
        private readonly IUniversityFormRepository _universityFormRepository;

        public UniversityFormService(IMapper mapper,
            IUniversityFormRepository universityFormRepository,
            ICsvHelper csvHelper)
        {
            _mapper = mapper;
            _universityFormRepository = universityFormRepository;
            _csvHelper = csvHelper;
        }

        public async Task<int> AddUniversityForm(UniversityFormModel universityFormModel)
        {
            return await _universityFormRepository
                .AddUniversityForm(_mapper.Map<UniversityForm>(universityFormModel));
        }

        public async Task<List<UniversityFormModel>> GetAll()
        {
            return _mapper.Map<List<UniversityFormModel>>(await _universityFormRepository.GetAll());
        }

        public async Task<string> CreateCsv()
        {
            return await _csvHelper.GetScv(await _universityFormRepository.GetAll());
        }
    }
}
