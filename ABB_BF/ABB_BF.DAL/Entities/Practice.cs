namespace ABB_BF.DAL.Entities
{
    public class Practice : AbstractCommonData
    {
        public virtual ICollection<PracticeFile> Files { get; set; }
    }
}
