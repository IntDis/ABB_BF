namespace ABB_BF.DAL.Entities
{
    public class PracticeFile : AbstractFormFile
    {
        public virtual Practice Practice { get; set; }
    }
}
