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
        private readonly IUniversityFormRepository _universityFormRepository;

        public UniversityFormService(IMapper mapper,
            IUniversityFormRepository universityFormRepository)
        {
            _mapper = mapper;
            _universityFormRepository = universityFormRepository;
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
    }
}
