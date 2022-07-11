using ABB_BF.DAL.Enums;

namespace ABB_BF.BLL.Models
{
    public class UniversityFormModel
    {
        public int Id { get; set; }
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public bool IsCertificated { get; set; }
        public CourseDirections Direction { get; set; }
        public ICollection<UniversityFileModel> UniversityFiles { get; set; }
    }
}
