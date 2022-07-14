using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IUniversityRepository
    {
        Task<int> AddUniversityForm(University university);
        Task<List<University>> GetAll(Filter filter);
        Task<List<University>> GetAll();
    }
}