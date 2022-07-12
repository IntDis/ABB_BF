namespace ABB_BF.Models.Requests
{
    public class AddProbationRequest
    {
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
