﻿namespace ABB_BF.DAL.Entities
{
    public class University : AbstractCommonData
    {
        public string College { get; set; }
        public DateOnly StartDate { get; set; }
        public int Duration { get; set; }
        public string Direction { get; set; }
        public bool IsCertificated { get; set; }
    }
}
