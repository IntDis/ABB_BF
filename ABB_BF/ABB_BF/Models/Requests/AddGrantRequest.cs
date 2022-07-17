

namespace ABB_BF.Models.Requests
{
    public class AddGrantRequest
    {
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string? Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public string College { get; set; }
        public float AverageMarks { get; set; }
        public int EducationLevel { get; set; }
        public int EducationForm { get; set; }
        public int Speciality { get; set; }
        public string? OtherGrants { get; set; }

    }
}
