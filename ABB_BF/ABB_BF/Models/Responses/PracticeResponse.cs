namespace ABB_BF.Models.Responses
{
    public class PracticeResponse
    {
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
        public int Course { get; set; }
        public string College { get; set; }
        public float AverageMarks { get; set; }
        public string Speciality { get; set; }
        public DateTime StartDate { get; set; }
        public string AboutMe { get; set; }
    }
}
