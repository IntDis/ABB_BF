﻿namespace ABB_BF.BLL.Models
{
    public class ProbationModel
    {
        public int Id { get; set; }
        public string Secondname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
        public DateTime StartDate { get; set; }
        public byte[] Cv { get; set; }
    }
}
