namespace ABB_BF.BLL.Models
{
    public class AbstractFormFileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
    }
}
