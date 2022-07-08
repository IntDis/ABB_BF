namespace ABB_BF.DAL.Entities
{
    public class FormFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
        public AbstractCommonData Form { get; set; }
    }
}
