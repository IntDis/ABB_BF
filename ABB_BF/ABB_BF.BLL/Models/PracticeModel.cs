namespace ABB_BF.BLL.Models
{
    public class PracticeModel
    {
        public int Id { get; set; }
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public string College { get; set; }
        public string Speciality { get; set; }
        public DateTime StartDate { get; set; }
        public string AboutMe { get; set; }
        public string Comment { get; set; }
        public List<PracticeFileModel> Files { get; set; }
    }
}
