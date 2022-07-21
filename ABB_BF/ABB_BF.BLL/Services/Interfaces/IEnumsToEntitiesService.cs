namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IEnumsToEntitiesService
    {
        Task<string> GetDefinitionByNumberFromCourseDirections(int? number);
        Task<string> GetDefinitionByNumberFromEducationForms(int? number);
        Task<string> GetDefinitionByNumberFromEducationLevels(int? number);
        Task<string> GetDefinitionByNumberFromSpecialities(int? number);
    }
}