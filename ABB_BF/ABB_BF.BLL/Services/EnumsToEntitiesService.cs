using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Entities.EnumsToEntities;
using ABB_BF.DAL.Repositories.Interfaces;

namespace ABB_BF.BLL.Services
{
    public class EnumsToEntitiesService : IEnumsToEntitiesService
    {
        private readonly IEnumsToEntitiesRepository _enumsToEntitiesRepository;

        public EnumsToEntitiesService(IEnumsToEntitiesRepository enumsToEntitiesRepository)
        {
            _enumsToEntitiesRepository = enumsToEntitiesRepository;
        }

        public async Task<string> GetDefinitionByNumberFromCourseDirections(int? number)
        {
            CourseDirection courseDirection = await _enumsToEntitiesRepository.GetCourseDirectionByNumber(number);

            if(courseDirection == null)
                throw new Exception("Not found");

            return courseDirection.Definition;
        }

        public async Task<string> GetDefinitionByNumberFromEducationForms(int? number)
        {
            var result = await _enumsToEntitiesRepository.GetEducationFormByNumber(number);

            if(result == null)
                throw new Exception("Not found");

            return result.Definition;
        }

        public async Task<string> GetDefinitionByNumberFromEducationLevels(int? number)
        {
            var result = await _enumsToEntitiesRepository.GetEducationLevelByNumber(number);

            if(result == null)
                throw new Exception("Not found");

            return result.Definition;
        }

        public async Task<string> GetDefinitionByNumberFromSpecialities(int? number)
        {
            var result = await _enumsToEntitiesRepository.GetSpecialityByNumber(number);

            if( result == null)
                throw new Exception("Not found");

            return result.Definition;
        }
    }
}
