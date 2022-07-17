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
        public string EducationLevel { get; set; }
        [DisplayName("Форма образования")]
        public string EducationForm { get; set; }
        [DisplayName("Средняя оценка")]
        public float AverageMarks { get; set; }
        [DisplayName("Специальность")]
        public string Speciality { get; set; }
        [DisplayName("Другие стипендии")]
        public string OtherGrants { get; set; }
    }
}
