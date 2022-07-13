﻿using ABB_BF.DAL.Enums;
using FileHelpers;

namespace ABB_BF.DAL.Entities
{
    [DelimitedRecord(",")]
    public class Grant : AbstractCommonData
    {
        public int Course { get; set; }
        public string College { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public float AverageMarks { get; set; }
        public Specialities Speciality { get; set; }
        public string OtherGrants { get; set; }
    }
}
