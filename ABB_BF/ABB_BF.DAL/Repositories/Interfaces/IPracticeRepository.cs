using ABB_BF.DAL.Entities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IPracticeRepository
    {
        Task<int> AddPractice(Practice practice);
    }
}