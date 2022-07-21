using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
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
            await _context.Grant.AddAsync(grant);
            await _context.SaveChangesAsync();

            return grant.Id;
        }

        public async Task<List<Grant>> GetAll()
        {
            return await _context.Grant.ToListAsync();
        }

        public async Task<List<Grant>> GetAll(Filter filter)
        {
            List<Grant> grants = await _context.Grant
                .Where(c =>
                    (filter.IsChecked == null || c.IsChecked != filter.IsChecked) &&
                    (filter.College == null || c.College == filter.College) &&
                    (c.CreationDate >= DateOnly.FromDateTime(filter.StartInterval)) &&
                    (c.CreationDate <= DateOnly.FromDateTime(filter.FinishInterval)) &&
                    (filter.Course == null || c.Course == filter.Course))
                    .ToListAsync();

            foreach (Grant grant in grants)
            {
                grant.IsChecked = true;
            }

            _context.SaveChanges();

            return grants;
        }
    }
}