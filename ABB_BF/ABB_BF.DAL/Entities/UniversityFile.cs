namespace ABB_BF.DAL.Entities
{
    public class UniversityFile : AbstractFormFile
    {
        public virtual UniversityForm University { get; set; }
    }
}
