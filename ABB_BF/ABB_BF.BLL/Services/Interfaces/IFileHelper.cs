using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IFileHelper
    {
        Task<string> GetScv<T>(List<T> forms) where T : class;
        Task<string> CreateFolderWithFormsInfo<T>(List<AbstractEntityModel> list, List<T> models) where T : class;
        Task<string> CreateZip(string startPath, string zipPath);
    }
}
