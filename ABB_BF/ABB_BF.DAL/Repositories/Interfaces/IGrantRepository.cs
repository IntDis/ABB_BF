using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IGrantRepository
    {
        Task<int> AddGrant(Grant grant);
        Task<List<Grant>> GetAll();
    }
}