

namespace ABB_BF.API.Models.Requests
{
    public class FilterRequest
    {
        public bool? IsChecked { get; set; }
        public string StartInterval { get; set; }
        public string FinishInterval { get; set; }
        public string? College { get; set; }
        public int? Course { get; set; }
        public int? CourseDirections { get; set; }
    }
}
