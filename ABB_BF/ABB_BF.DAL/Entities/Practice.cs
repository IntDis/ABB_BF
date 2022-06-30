using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class Practice : AbstractCommonData
    {
        public int Course { get; set; }

        public string College { get; set; }

        public float AverageMarks { get; set; }

        public string Speciality { get; set; }

        public DateTime StartDate { get; set; }

        public string AboutMe { get; set; }
    }
}
