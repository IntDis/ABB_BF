namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IEnumsToEntitiesService
    {
        Task<string> GetDefinitionByNumberFromCourseDirections(int number);
    }
}