using ABB_BF.DAL.Enums;
using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    public class University : AbstractCommonData
    {
        public string College { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public CourseDirections Direction { get; set; }
        public bool IsCertificated { get; set; }
    }
}
