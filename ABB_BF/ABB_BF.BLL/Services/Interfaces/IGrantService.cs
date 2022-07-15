using ABB_BF.BLL.Models;
using ABB_BF.DAL.Entities;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IGrantService
    {
        Task<int> AddGrant(GrantModel grandModel);
        Task<List<GrantModel>> GetAll(FilterModel filter);
        Task<string> CreateCsv(FilterModel filter, string fileName);
    }
}