using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IProbationRepository
    {
        Task<int> AddProbation(Probation probation);
        Task<List<Probation>> GetAll(Filter filter);
    }
}