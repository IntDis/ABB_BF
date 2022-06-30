using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IPracticeService
    {
        Task<int> AddPractice(PracticeModel practiceModel);
        Task<List<PracticeModel>> GetAll();

        Task<string> CreateCsv();
    }
}
