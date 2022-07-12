using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class GrantRepository : IGrantRepository
    {
        private readonly Context _context;

        public GrantRepository(Context context)
        {
            _context = context;
        }

        public async Task<int> AddGrant(Grant grant)
        {
            await _context.GrantForms.AddAsync(grant);
            await _context.SaveChangesAsync();

            return grant.Id;
        }

        public async Task<List<Grant>> GetAll()
        {
            return await _context.GrantForms.ToListAsync();
        }
    }
}