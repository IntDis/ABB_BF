using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class PracticeRepository : IPracticeRepository
    {
        private readonly Context _context;

        public PracticeRepository(Context context)
        {
            _context = context;
        }

        public async Task<int> AddPractice(Practice practice)
        {
            await _context.PracticeForms.AddAsync(practice);
            await _context.SaveChangesAsync();

            return practice.Id;
        }

        public async Task<List<Practice>> GetAll()
        {
            return await _context.PracticeForms.ToListAsync();
        }
    }
}