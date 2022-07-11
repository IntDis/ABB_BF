namespace ABB_BF.DAL.Entities
{
    public class AbstractFormFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
    }
}
