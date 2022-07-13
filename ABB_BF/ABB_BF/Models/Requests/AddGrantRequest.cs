﻿using ABB_BF.DAL.Enums;

namespace ABB_BF.Models.Requests
{
    public class AddGrantRequest
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public string College { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public float AverageMarks { get; set; }
        public Specialities Speciality { get; set; }
        public string OtherGrants { get; set; }
    }
}
