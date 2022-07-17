using ABB_BF.DAL.Enums;

namespace ABB_BF.DAL.Entities
{
    public class Grant : AbstractCommonData
    {
        public int Course { get; set; }
        public string College { get; set; }
        public EducationLevels EducationLevel { get; set; }
        public float AverageMarks { get; set; }
        public Specialities Speciality { get; set; }
        public string OtherGrants { get; set; }
    }
}
