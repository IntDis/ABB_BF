namespace ABB_BF.DAL.Entities
{
    public class Probation : AbstractCommonData
    {
        public virtual ICollection<ProbationFile> Files { get; set; }

    }
}
