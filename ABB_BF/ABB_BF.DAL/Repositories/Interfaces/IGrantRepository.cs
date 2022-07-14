using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IGrantRepository
    {
        Task<int> AddGrant(Grant grant);
        Task<List<Grant>> GetAll();
        Task<List<Grant>> GetByFilters(Filter filter);
    }
}