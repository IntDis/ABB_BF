using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class GrantService : IGrantService
    {
        private readonly IMapper _mapper;
        private readonly IGrantRepository _grantRepository;
        private readonly IFileHelper _fileHelper;
        private readonly ICollegeService _collegeService;

        public GrantService(
            IMapper mapper,
            IGrantRepository grantRepository,
            IFileHelper fileHelper,
            ICollegeService collegeService)
        {
            _mapper = mapper;
            _grantRepository = grantRepository;
            _fileHelper = fileHelper;
            _collegeService = collegeService;
        }

        public async Task<int> AddGrant(GrantModel grantModel)
        {
            grantModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);

            await _collegeService.AddCollege(grantModel.College);

            Grant grant = _mapper.Map<Grant>(grantModel);

            return await _grantRepository.AddGrant(grant);
        }

        public async Task<List<GrantModel>> GetAll(FilterModel filter)
        {
            return _mapper.Map<List<GrantModel>>(await _grantRepository.GetAll(_mapper.Map<Filter>(filter)));
        }

        public async Task<string> CreateCsv(FilterModel filter, string fileName)
        {
            if (filter.IsChecked == false)
            {
                filter.IsChecked = null;
            }

            return await _fileHelper.CreateXlsx(await GetAll(filter), fileName);
        }
    }
}
