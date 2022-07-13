using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class Practice : AbstractCommonData
    {
        [FieldHidden]
        public virtual ICollection<PracticeFile> Files { get; set; }
    }
}
