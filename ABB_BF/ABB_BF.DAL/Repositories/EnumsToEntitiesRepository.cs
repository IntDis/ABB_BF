using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class EnumsToEntitiesRepository : IEnumsToEntitiesRepository
    {
        private readonly Context _context;

        public EnumsToEntitiesRepository(Context context)
        {
            _context = context;
        }

        public async Task<EnumsToEntities> GetDefinitionByNumberFromCourseDirections(int number)
        {
            return (await _context.CourseDirections.FirstOrDefaultAsync(o => o.Number == number));
        }

        public async Task<string> GetDefinitionByNumberFromEducationForms(int number)
        {
            //return (await _context.EducationForms.FirstOrDefaultAsync(o => o.Number == number)).Definition;
            return "sad";
        }

        public async Task<string> GetDefinitionByNumberFromEducationLevels(int number)
        {
            //return (await _context.EducationLevels.FirstOrDefaultAsync(o => o.Number == number)).Definition;
            return "sad";

        }
        public async Task<string> GetDefinitionByNumberFromSpecialities(int number)
        {
            //return (await _context.EducationLevels.FirstOrDefaultAsync(o => o.Number == number)).Definition;
            return "sad";

        }

    }
}
