namespace ABB_BF.BLL.Services.Interfaces
{
    public interface ICollegeService
    {
        Task<List<string>> GetAllColleges();
    }
}