namespace ABB_BF.DAL.Entities
{
    public class UniversityFiles : AbstractFormFile
    {
        public virtual UniversityForm University { get; set; }
    }
}
