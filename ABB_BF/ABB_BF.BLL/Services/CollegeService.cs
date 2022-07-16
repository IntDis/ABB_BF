using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using AutoMapper;

namespace ABB_BF.BLL.Services
{
    public class CollegeService : ICollegeService
    {
        private readonly ICollegeRepository _collegeRepository;
        private readonly IMapper _mapper;

        public CollegeService(
            ICollegeRepository collegeRepository,
            IMapper mapper)
        {
            _collegeRepository = collegeRepository;
            _mapper = mapper;
        }

        public async Task<List<CollegeModel>> GetAllColleges()
        {
            return _mapper.Map<List<CollegeModel>>(await _collegeRepository.GetAllColleges());
        }

        public async Task AddCollege(string name)
        {
            CollegeModel college = new CollegeModel()
            {
                Name = name,
            };

            if (!(await CollegeIsExistInDb(college)))
            {
                await _collegeRepository.AddCollege(_mapper.Map<College>(college));
            }
        }

        private async Task<bool> CollegeIsExistInDb(CollegeModel college)
        {
            if (await _collegeRepository.GetCollegeByName(college.Name) is not null)
            {
                return true;
            }

            return false;
        }
    }
}
