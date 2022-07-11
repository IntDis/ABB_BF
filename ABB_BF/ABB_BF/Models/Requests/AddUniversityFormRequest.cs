namespace ABB_BF.Models.Requests
{
    public class AddUniversityFormRequest
    {
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
