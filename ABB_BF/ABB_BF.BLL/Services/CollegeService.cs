using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;

namespace ABB_BF.BLL.Services
{
    public class CollegeService : ICollegeService
    {
        private readonly IUniversityRepository _universityRepository;
        private readonly IGrantRepository _grnatRepository;

        public CollegeService(IUniversityRepository universityRepository, IGrantRepository grantRepository)
        {
            _universityRepository = universityRepository;
            _grnatRepository = grantRepository;
        }

        public async Task<List<string>> GetAllColleges()
        {
            List<string> result = new();
            result.AddRange(await GetGrantColleges());
            result.AddRange(await GetUniversityColleges());

            return result.Distinct().ToList();
        }

        private async Task<List<string>> GetGrantColleges()
        {
            List<Grant> grants = await _grnatRepository.GetAll();

            List<string> colleges = new();

            foreach (Grant grant in grants)
            {
                colleges.Add(grant.College);
            }

            return colleges;
        }

        private async Task<List<string>> GetUniversityColleges()
        {
            List<University> universities = await _universityRepository.GetAll();

            List<string> colleges = new();

            foreach (University university in universities)
            {
                colleges.Add(university.College);
            }

            return colleges;
        }
    }
}
