using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class UniversityFormRepository : IUniversityRepository
    {
        private readonly Context _context;

        public UniversityFormRepository(Context context)
        {
            _context = context;
        }

        public async Task<int> AddUniversityForm(University university)
        {
            await _context.University.AddAsync(university);
            await _context.SaveChangesAsync();
            return university.Id;
        }

        public async Task<List<University>> GetAll()
        {
            return await _context.University.ToListAsync();
        }

        public async Task<List<University>> GetAll(Filter filter)
        {
            List<University> universities = await _context.University
                .Where(c =>
                    (filter.IsChecked == null || c.IsChecked != filter.IsChecked) && 
                    (filter.College == null || c.College != filter.College) &&
                    (filter.CourseDirections == null || c.Direction != filter.CourseDirections) &&
                    (c.CreationDate >= DateOnly.FromDateTime(filter.StartInterval)) &&
                    (c.CreationDate <= DateOnly.FromDateTime(filter.FinishInterval))).ToListAsync();

            foreach (University university in universities)
            {
                university.IsChecked = true;
            }

            _context.SaveChanges();

            return universities;
        }
    }
}
