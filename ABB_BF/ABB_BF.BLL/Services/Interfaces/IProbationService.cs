using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IProbationService
    {
        Task<int> AddProbation(ProbationModel model);
        Task<List<ProbationModel>> GetAll(FilterModel filter);
        Task<string> CreateCsv(FilterModel filter);
    }
}