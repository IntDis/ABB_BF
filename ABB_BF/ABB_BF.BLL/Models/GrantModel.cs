using ABB_BF.DAL.Enums;
using System.ComponentModel;

namespace ABB_BF.BLL.Models
{
    public class GrantModel : AbstractEntityModel
    {
        [DisplayName("Курс")]
        public int Course { get; set; }
        [DisplayName("Учебное заведение")]
        public string College { get; set; }
        [DisplayName("Уровень образования")]
        public EducationLevel EducationLevel { get; set; }
        [DisplayName("Средняя оценка")]
        public float AverageMarks { get; set; }
        [DisplayName("Специальность")]
        public Specialities Speciality { get; set; }
        [DisplayName("Другие стипендии")]
        public string OtherGrants { get; set; }
    }
}
