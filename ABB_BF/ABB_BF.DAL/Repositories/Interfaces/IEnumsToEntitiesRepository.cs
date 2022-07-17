using ABB_BF.DAL.Entities.EnumsToEntities;

namespace ABB_BF.DAL.Repositories.Interfaces
{
    public interface IEnumsToEntitiesRepository
    {
        Task<CourseDirection> GetCourseDirectionByNumber(int? number);
        Task<EducationForm> GetEducationFormByNumber(int? number);
        Task<EducationLevel> GetEducationLevelByNumber(int? number);
        Task<Speciality> GetSpecialityByNumber(int? number);
    }
}