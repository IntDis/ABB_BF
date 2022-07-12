using ABB_BF.DAL.Enums;

namespace ABB_BF.BLL.Models
{
    public class UniversityModel : AbstractEntityModel
    {
        public bool IsCertificated { get; set; }
        public CourseDirections Direction { get; set; }
    }
}
