using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IUniversityFormRepository
    {
        Task<int> AddUniversityForm(UniversityForm university);
    }
}