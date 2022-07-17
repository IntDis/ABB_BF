using ABB_BF.DAL.Enums;
using System.ComponentModel;

namespace ABB_BF.BLL.Models
{
    public class UniversityModel : AbstractEntityModel
    {
        [DisplayName("Учебное заведение")]
        public string College { get; set; }
        [DisplayName("Дата начала")]
        public DateOnly StartDate { get; set; }
        [DisplayName("Продолжительсноть")]
        public int Duration { get; set; }
        [DisplayName("Направление")]
        public CourseDirections Direction { get; set; }
        [DisplayName("Наличие сертификата")]
        public bool IsCertificated { get; set; }
        [DisplayName("Дата подачи заявки")]
        public DateOnly CreationDate { get; set; }
    }
}
