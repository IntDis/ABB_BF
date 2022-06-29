namespace ABB_BF.Models.Requests
{
    public class AddGrantRequest
    {
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
        public DateTime BirthDate { get; set; }
        public int Course { get; set; }
        public string College { get; set; }
        public string EducationLevel { get; set; }
        public float AverageMarks { get; set; }
        public string Speciality { get; set; }
        public string EducationForm { get; set; }
        public string OtherGrants { get; set; }
    }
}
