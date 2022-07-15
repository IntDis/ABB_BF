namespace ABB_BF.API.Models.Responses
{
    public class ProbationResponse
    {
        public int Id { get; set; }
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<IFormFile> Files { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
