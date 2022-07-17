namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IEnumsToEntitiesRepository
    {
        Task<string> GetDefinitionByNumberFromCourseDirections(int number);
        Task<string> GetDefinitionByNumberFromEducationForms(int number);
        Task<string> GetDefinitionByNumberFromEducationLevels(int number);
        Task<string> GetDefinitionByNumberFromSpecialities(int number);
    }
}