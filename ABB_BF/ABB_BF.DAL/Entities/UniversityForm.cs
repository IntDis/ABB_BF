using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class UniversityForm : AbstractCommonData
    {
        public string Comment { get; set; }
        public bool IsCertificated { get; set; }
        //enam s napravleniyami
        public ICollection<UniversityFiles> UniversityFiles { get; set; }
    }
}
