using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IGrantService
    {
        Task<int> AddGrant(GrantModel grandModel);
    }
}