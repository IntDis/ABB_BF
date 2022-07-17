using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class UniversityService : IUniversityService
    {
        private readonly IMapper _mapper;
        private readonly IUniversityRepository _universityFormRepository;
        private readonly IFileHelper _fileHelper;
        private readonly ICollegeService _collegeService;
        private readonly IEnumsToEntitiesRepository _enumsToEntitiesRepository;

        public UniversityService(IMapper mapper,
            IUniversityRepository universityFormRepository,
            IFileHelper fileHelper,
            ICollegeService collegeService,
            IEnumsToEntitiesRepository enumsToEntitiesRepository)
        {
            _mapper = mapper;
            _universityFormRepository = universityFormRepository;
            _fileHelper = fileHelper;
            _collegeService = collegeService;
            _enumsToEntitiesRepository = enumsToEntitiesRepository;
        }

        public async Task<int> AddUniversityForm(UniversityModel universityModel)
        {
            universityModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);

            await _collegeService.AddCollege(universityModel.College);


            return await _universityFormRepository
                .AddUniversityForm(_mapper.Map<University>(universityModel));
        }

        public async Task<List<UniversityModel>> GetAll(FilterModel filter)
        {
            return _mapper.Map<List<UniversityModel>>(await _universityFormRepository.GetAll(_mapper.Map<Filter>(filter)));
        }

        public async Task<string> CreateXlsx(FilterModel filter, string fileName)
        {
            if (filter.IsChecked == false)
            {
                filter.IsChecked = null;
            }

            return await _fileHelper.CreateXlsx(await GetAll(filter), fileName);
        }
    }
}
