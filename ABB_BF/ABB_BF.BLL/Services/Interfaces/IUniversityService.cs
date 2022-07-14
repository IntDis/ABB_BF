using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IUniversityService
    {
        Task<int> AddUniversityForm(UniversityModel universityFormModel);
        Task<List<UniversityModel>> GetAll(FilterModel filter);
        Task<string> CreateCsv(FilterModel filter);
    }
}