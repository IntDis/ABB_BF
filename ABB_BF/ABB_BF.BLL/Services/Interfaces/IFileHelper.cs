using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IFileHelper
    {
        Task<string> GetScv<T>(List<T> forms) where T : class;
        Task<string> CreateZipWithFormsInfo(List<AbstractEntityModel> list);
    }
}
