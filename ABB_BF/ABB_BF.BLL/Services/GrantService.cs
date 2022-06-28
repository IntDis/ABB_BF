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

        public GrantService(IMapper mapper, IGrantRepository grantRepository)
        {
            _mapper = mapper;
            _grantRepository = grantRepository;
        }

        public async Task<int> AddGrant(GrantModel grandModel)
        {
            Grant grant = _mapper.Map<Grant>(grandModel);

            return await _grantRepository.AddGrant(grant);
        }
    }
}
