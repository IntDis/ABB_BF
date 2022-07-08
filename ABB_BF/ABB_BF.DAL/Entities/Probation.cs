using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class Probation : AbstractCommonData
    {
        public DateTime  StartDate { get; set; }
        public byte[] Cv { get; set; }
    }
}
