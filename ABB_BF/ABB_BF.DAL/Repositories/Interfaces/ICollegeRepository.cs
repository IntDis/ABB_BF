using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface ICollegeRepository
    {
        Task AddCollege(College college);
        Task<List<College>> GetAllColleges();
    }
}