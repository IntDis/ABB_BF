namespace ABB_BF.DAL.Entities
{
    public class Grant : CommonData
    {
        public DateTime BirthDate { get; set; }

        public int Course { get; set; }

        public string College { get; set; }

        public string EducationLevel { get; set; }

        public float AverageMarks { get; set; }

        public string EducationForm { get; set; }

        public string OtherGrants { get; set; }
    }
}
