using ABB_BF.BLL.Models;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IFileHelper
    {
        Task<string> CreateXlsx<T>(List<T> forms, string fileName) where T : class;
        Task<string> CreateFolderWithFormsInfo<T>(List<AbstractEntityModel> list, List<T> models) where T : class;
        Task<string> CreateZip(string startPath, string zipPath);
        string CreateFileNmae(FilterModel filter, string modelName);
    }
}
