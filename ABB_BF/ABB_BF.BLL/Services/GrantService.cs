using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class GrantService : IGrantService
    {
        private readonly IMapper _mapper;
        private readonly IGrantRepository _grantRepository;
        private readonly IFileHelper _fileHelper;

        public GrantService(IMapper mapper, IGrantRepository grantRepository, IFileHelper fileHelper)
        {
            _mapper = mapper;
            _grantRepository = grantRepository;
            _fileHelper = fileHelper;
        }

        public async Task<int> AddGrant(GrantModel grantModel)
        {
            grantModel.CreationDate = DateOnly.FromDateTime(DateTime.Now);

            Grant grant = _mapper.Map<Grant>(grantModel);

            return await _grantRepository.AddGrant(grant);
        }

        public async Task<List<GrantModel>> GetAll()
        {
            return _mapper.Map<List<GrantModel>>(await _grantRepository.GetAll());
        }

        public async Task<string> CreateCsv()
        {
            return _fileHelper.CreateXlsx(await _grantRepository.GetAll());
        }
    }
}
