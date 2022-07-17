namespace ABB_BF.Models.Responses
{
    public class UniversityResponse
    {
        public int Id { get; set; }
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string? Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string College { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public string Direction { get; set; }
        public bool IsCertificated { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
