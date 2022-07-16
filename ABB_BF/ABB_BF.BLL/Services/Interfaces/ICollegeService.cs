using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface ICollegeService
    {
        Task<List<CollegeModel>> GetAllColleges();
        Task AddCollege(string name);
    }
}