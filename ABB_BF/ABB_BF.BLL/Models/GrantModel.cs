using ABB_BF.DAL.Enums;

namespace ABB_BF.BLL.Models
{
    public class GrantModel : AbstractEntityModel
    {
        public int Course { get; set; }
        public string College { get; set; }
        public string EducationLevel { get; set; }
        public float AverageMarks { get; set; }
        public Specialities Speciality { get; set; }
        public string OtherGrants { get; set; }
    }
}
