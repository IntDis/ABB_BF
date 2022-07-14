using ABB_BF.DAL.Enums;

namespace ABB_BF.API.Models.Requests
{
    public class FilterRequest
    {
        public bool? IsChecked { get; set; }
        public DateTime? StartInterval { get; set; }
        public DateTime? FinishInterval { get; set; }
        public string? College { get; set; }
        public int? Course { get; set; }
        public CourseDirections? CourseDirections { get; set; }
    }
}
