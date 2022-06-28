using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Repositories.Interfaces;

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
            await _context.Probations.AddAsync(probation);
            _context.SaveChanges();
            return probation.Id;
        }
    }
}
