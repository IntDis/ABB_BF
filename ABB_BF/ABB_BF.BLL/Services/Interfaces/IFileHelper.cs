namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IFileHelper
    {
        Task<string> GetScv<T>(List<T> forms) where T : class;
    }
}
