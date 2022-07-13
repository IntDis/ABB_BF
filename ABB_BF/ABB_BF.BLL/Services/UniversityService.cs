using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class UniversityService : IUniversityService
    {
        private readonly IMapper _mapper;
        private readonly IFileHelper _csvHelper;
        private readonly IUniversityRepository _universityFormRepository;

        public UniversityService(IMapper mapper,
            IUniversityRepository universityFormRepository,
            IFileHelper csvHelper)
        {
            _mapper = mapper;
            _universityFormRepository = universityFormRepository;
            _csvHelper = csvHelper;
        }

        public async Task<int> AddUniversityForm(UniversityModel universityFormModel)
        {
            return await _universityFormRepository
                .AddUniversityForm(_mapper.Map<University>(universityFormModel));
        }

        public async Task<List<UniversityModel>> GetAll()
        {
            return _mapper.Map<List<UniversityModel>>(await _universityFormRepository.GetAll());
        }

        public async Task<string> CreateCsv()
        {
            return _csvHelper.CreateXlsx(await _universityFormRepository.GetAll());
        }
    }
}
