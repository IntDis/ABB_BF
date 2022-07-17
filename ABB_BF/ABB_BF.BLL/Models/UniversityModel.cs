using ABB_BF.DAL.Enums;
using System.ComponentModel;

namespace ABB_BF.BLL.Models
{
    public class UniversityModel
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
        [DisplayName("Учебное заведение")]
        public string College { get; set; }
        [DisplayName("Дата начала")]
        public DateOnly StartDate { get; set; }
        [DisplayName("Продолжительсноть")]
        public int Duration { get; set; }
        [DisplayName("Направление")]
        public int Direction { get; set; }
        [DisplayName("Наличие сертификата")]
        public bool IsCertificated { get; set; }
        [DisplayName("Дата подачи заявки")]
        public DateOnly CreationDate { get; set; }
    }
}
