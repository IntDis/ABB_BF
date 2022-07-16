using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class CollegeRepository : ICollegeRepository
    {
        private readonly Context _context;

        public CollegeRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<College>> GetAllColleges()
        {
            return await _context.College.ToListAsync();
        }

        public async Task AddCollege(College college)
        {
            await _context.College.AddAsync(college);
            await _context.SaveChangesAsync();
        }
    }
}
