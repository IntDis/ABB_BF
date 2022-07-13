using OfficeOpenXml.Attributes;

namespace ABB_BF.BLL.Models
{
    public class AbstractEntityModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [EpplusIgnore]
        public List<AbstractFormFileModel> Files { get; set; }
    }
}
