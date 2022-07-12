namespace ABB_BF.BLL.Models
{
    public class PracticeModel : AbstractEntityModel
    {
        public int Course { get; set; }
        public string College { get; set; }
        public string Speciality { get; set; }
        public DateTime StartDate { get; set; }
        public string AboutMe { get; set; }
        public string Comment { get; set; }
    }
}
