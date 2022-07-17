using ABB_BF.BLL.Services.Interfaces;
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

        public async Task<string> GetDefinitionByNumberFromCourseDirections(int number)
        {
            var result = await _enumsToEntitiesRepository.GetDefinitionByNumberFromCourseDirections(number);

            if (result == null)
                throw new Exception("Not found");

            return result.Definition;
        }
    }
}
