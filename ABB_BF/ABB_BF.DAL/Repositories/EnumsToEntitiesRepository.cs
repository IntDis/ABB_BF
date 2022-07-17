using ABB_BF.DAL.Entities.EnumsToEntities;
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

        public async Task<CourseDirection> GetCourseDirectionByNumber(int? number)
        {
            return await _context.CourseDirections.FirstOrDefaultAsync(o => o.Number == number);
        }

        public async Task<EducationForm> GetEducationFormByNumber(int? number)
        {
            return await _context.EducationForms.FirstOrDefaultAsync(o => o.Number == number);
        }

        public async Task<EducationLevel> GetEducationLevelByNumber(int? number)
        {
            return await _context.EducationLevels.FirstOrDefaultAsync(o => o.Number == number);

        }
        public async Task<Speciality> GetSpecialityByNumber(int? number)
        {
            return await _context.Specialities.FirstOrDefaultAsync(o => o.Number == number);
        }
    }
}
