﻿using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class Grant : AbstractCommonData
    {
        public int Course { get; set; }
        public string College { get; set; }
        public string EducationLevel { get; set; }
        public float AverageMarks { get; set; }
        //сделать енам public string Speciality { get; set; }
        public string OtherGrants { get; set; }
        public virtual ICollection<GrantFiles> GrantFiles { get; set; }
    }
}
