namespace ABB_BF.DAL.Models
{
    public class Filter
    {
        public bool? IsChecked { get; set; }
        public DateTime StartInterval { get; set; }
        public DateTime FinishInterval { get; set; }
        public string? College { get; set; }
        public int? Course { get; set; }
        public string? CourseDirections { get; set; }
    }
}
