using ABB_BF.DAL.Entities;
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

        public async Task<List<Probation>> GetAll()
        {
            return await _context.ProbationForms.ToListAsync();
        }

        public async Task<Probation> GetById(int id)
        {
            return await _context.ProbationForms.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
