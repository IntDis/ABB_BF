using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IUniversityFormService
    {
        Task<int> AddUniversityForm(UniversityFormModel universityFormModel);
    }
}