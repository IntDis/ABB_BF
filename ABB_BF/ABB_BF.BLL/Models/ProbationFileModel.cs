namespace ABB_BF.BLL.Models
{
    public class ProbationFileModel
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
        public ProbationModel Probation { get; set; }
    }
}
