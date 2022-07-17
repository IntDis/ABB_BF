using ABB_BF.DAL.Entities;

namespace ABB_BF.Models.Requests
{
    public class AddPracticeRequest
    {
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string? Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual List<IFormFile> Files { get; set; }
    }
}
