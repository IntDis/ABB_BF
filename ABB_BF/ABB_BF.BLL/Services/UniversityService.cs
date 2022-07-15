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
        private readonly IFileHelper _csvHelper;
        private readonly IUniversityRepository _universityFormRepository;
        private readonly IFileHelper _fileHelper;

        public UniversityService(IMapper mapper,
            IUniversityRepository universityFormRepository,
            IFileHelper csvHelper,
            IFileHelper fileHelper)
        {
            _mapper = mapper;
            _universityFormRepository = universityFormRepository;
            _csvHelper = csvHelper;
            _fileHelper = fileHelper;
        }

        public async Task<int> AddUniversityForm(UniversityModel universityFormModel)
        {
            universityFormModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);

            return await _universityFormRepository
                .AddUniversityForm(_mapper.Map<University>(universityFormModel));
        }

        public async Task<List<UniversityModel>> GetAll(FilterModel filter)
        {
            return _mapper.Map<List<UniversityModel>>(await _universityFormRepository.GetAll(_mapper.Map<Filter>(filter)));
        }

        public async Task<string> CreateCsv(FilterModel filter, string fileName)
        {
            if (filter.IsChecked == false)
            {
                filter.IsChecked = null;
            }

            return _fileHelper.CreateXlsx(await GetAll(filter), fileName);
        }
    }
}
