using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IUniversityRepository
    {
        Task<int> AddUniversityForm(University university);
        Task<List<University>> GetAll();
    }
}