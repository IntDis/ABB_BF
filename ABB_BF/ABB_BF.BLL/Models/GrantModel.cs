using ABB_BF.DAL.Enums;
using System.ComponentModel;

namespace ABB_BF.BLL.Models
{
    public class GrantModel
    {
        [DisplayName("Номер заявки")]
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Firstname { get; set; }
        [DisplayName("Фамилия")]
        public string Secondname { get; set; }
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        [DisplayName("Электронная почта")]
        public string Email { get; set; }
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
        [DisplayName("Дата подачи заявки")]
        public DateOnly CreationDate { get; set; }
    }
}
