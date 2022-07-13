using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class Probation : AbstractCommonData
    {
        [FieldHidden]
        public virtual ICollection<ProbationFile> Files { get; set; }

    }
}
