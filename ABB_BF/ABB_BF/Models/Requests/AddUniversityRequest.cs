using ABB_BF.DAL.Enums;

namespace ABB_BF.Models.Requests
{
    public class AddUniversityRequest
    {
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string College { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int Course { get; set; }
        public int Direction { get; set; }
        public bool IsCertificated { get; set; }
    }
}
