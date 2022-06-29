using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;

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
            await _context.Practices.AddAsync(practice);
            await _context.SaveChangesAsync();

            return practice.Id;
        }
    }
}