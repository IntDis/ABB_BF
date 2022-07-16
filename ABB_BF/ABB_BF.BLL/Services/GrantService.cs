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
        private readonly IModelsService _modelsService;

        public GrantService(
            IMapper mapper, 
            IGrantRepository grantRepository, 
            IFileHelper fileHelper, 
            IModelsService modelsService)
        {
            _mapper = mapper;
            _grantRepository = grantRepository;
            _fileHelper = fileHelper;
            _modelsService = modelsService;
        }

        public async Task<int> AddGrant(GrantModel grantModel)
        {
            if (!_modelsService.IsNumberValid(grantModel.Phone))
            {
                throw new ArgumentException("Введен неверный номер");
            }
            else if (!_modelsService.IsEmailValid(grantModel.Email))
            {
                throw new ArgumentException("Введен неверный e-mail");
            }

            grantModel.Phone = _modelsService.FixPhoneNumber(grantModel.Phone);

            grantModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);

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

            return _fileHelper.CreateXlsx(await GetAll(filter), fileName);
        }
    }
}
