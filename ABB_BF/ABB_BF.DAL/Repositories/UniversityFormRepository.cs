using ABB_BF.DAL.Entities;
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
            await _context.UniversityForms.AddAsync(university);
            await _context.SaveChangesAsync();
            return university.Id;
        }

        public async Task<List<University>> GetAll()
        {
            return await _context.UniversityForms.ToListAsync();
        }
    }
}
