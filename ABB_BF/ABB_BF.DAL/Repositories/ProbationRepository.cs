using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;
using ABB_BF.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL.Repositories
{
    public class ProbationRepository : IProbationRepository
    {
        private readonly Context _context;

        public ProbationRepository(Context context)
        {
            _context = context;
        }

        public async Task<int> AddProbation(Probation probation)
        {
            await _context.ProbationForms.AddAsync(probation);
            await _context.SaveChangesAsync();
            return probation.Id;
        }

        public async Task<List<Probation>> GetAll(Filter filter)
        {
            List<Probation> probations = await _context.ProbationForms
                .Where(c =>
                    (filter.IsChecked == null || c.IsChecked != filter.IsChecked) &&
                    (c.CreationDate >= DateOnly.FromDateTime(filter.StartInterval)) &&
                    (c.CreationDate <= DateOnly.FromDateTime(filter.FinishInterval))).ToListAsync();

            foreach (Probation probation in probations)
            {
                probation.IsChecked = true;
            }

            _context.SaveChanges();

            return probations;
        }
    }
}
