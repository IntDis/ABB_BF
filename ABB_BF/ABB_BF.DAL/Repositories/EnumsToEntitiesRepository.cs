using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_BF.DAL.Repositories
{
    public class EnumsToEntitiesRepository : IEnumsToEntitiesRepository
    {
        private readonly Context _context;

        public async Task<string> GetDefinitionByNumberFromCourseDirections(int number)
        {
            return (await _context.CourseDirections.FirstOrDefaultAsync(o => o.Number == number)).Definition;
        }

        public async Task<string> GetDefinitionByNumberFromEducationForms(int number)
        {
            return (await _context.EducationForms.FirstOrDefaultAsync(o => o.Number == number)).Definition;
        }

        public async Task<string> GetDefinitionByNumberFromEducationLevels(int number)
        {
            return (await _context.EducationLevels.FirstOrDefaultAsync(o => o.Number == number)).Definition;
        }
        public async Task<string> GetDefinitionByNumberFromSpecialities(int number)
        {
            return (await _context.EducationLevels.FirstOrDefaultAsync(o => o.Number == number)).Definition;
        }

    }
}
