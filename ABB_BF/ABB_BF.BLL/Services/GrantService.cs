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
        private readonly ICsvHelper _csvHelper;

        public GrantService(IMapper mapper, IGrantRepository grantRepository, ICsvHelper csvHelper)
        {
            _mapper = mapper;
            _grantRepository = grantRepository;
            _csvHelper = csvHelper;
        }

        public async Task<int> AddGrant(GrantModel grandModel)
        {
            Grant grant = _mapper.Map<Grant>(grandModel);

            return await _grantRepository.AddGrant(grant);
        }

        public async Task<List<GrantModel>> GetAll()
        {
            return _mapper.Map<List<GrantModel>>(await _grantRepository.GetAll());
        }

        public async Task<string> CreateCsv()
        {
            return await _csvHelper.GetScv(await _grantRepository.GetAll());
        }
    }
}
