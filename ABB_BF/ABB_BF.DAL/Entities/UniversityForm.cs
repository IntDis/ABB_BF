using ABB_BF.DAL.Enums;
using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class UniversityForm : AbstractCommonData
    {
        public string Comment { get; set; }
        public bool IsCertificated { get; set; }
        public CourseDirections Direction { get; set; }
        public ICollection<UniversityFile> UniversityFiles { get; set; }
    }
}
