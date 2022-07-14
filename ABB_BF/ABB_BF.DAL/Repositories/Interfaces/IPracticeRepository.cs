using ABB_BF.DAL.Entities;
using ABB_BF.DAL.Models;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IPracticeRepository
    {
        Task<int> AddPractice(Practice practice);
        Task<List<Practice>> GetAll(Filter filter);
    }
}