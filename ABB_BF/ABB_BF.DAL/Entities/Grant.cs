namespace ABB_BF.DAL.Entities
{
    public class Grant : AbstractCommonData
    {
        public DateTime BirthDate { get; set; }

        public int Course { get; set; }

        public string College { get; set; }

        public string EducationLevel { get; set; }

        public float AverageMarks { get; set; }

        public string Speciality { get; set; }

        public string EducationForm { get; set; }

        public string OtherGrants { get; set; }
    }
}
