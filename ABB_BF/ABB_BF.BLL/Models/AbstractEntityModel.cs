using OfficeOpenXml.Attributes;
using System.ComponentModel;

namespace ABB_BF.BLL.Models
{
    public class AbstractEntityModel
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
        [DisplayName("Дата подачи заявки")]
        public DateOnly CreationDate { get; set; }
        [EpplusIgnore]
        public List<AbstractFormFileModel> Files { get; set; }
    }
}
