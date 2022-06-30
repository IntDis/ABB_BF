namespace ABB_BF.BLL.Services.Interfaces
{
    public interface ICsvHelper
    {
        Task<string> GetScv<T>(List<T> forms) where T : class;
    }
}
