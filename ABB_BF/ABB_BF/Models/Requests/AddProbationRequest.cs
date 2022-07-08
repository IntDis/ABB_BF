namespace ABB_BF.Models.Requests
{
    public class AddProbationRequest
    {
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
        public DateTime StartDate { get; set; }
        public IFormFile Cv { get; set; }
    }
}
