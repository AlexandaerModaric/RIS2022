using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Report
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Patientid { get; set; }
        public DateTime? Imagedate { get; set; }
        public int? Referingdoctorid { get; set; }
        public int Raddoctorid { get; set; }
        public int? Physicianid { get; set; }
        public DateTime Reportdate { get; set; }
        public byte[]? Title { get; set; }
        public byte[]? Meidcalhistory { get; set; }
        public byte[]? Alergy { get; set; }
        public byte[]? Reportbody { get; set; }
        public byte[]? Notes { get; set; }
        public string? Audiopath { get; set; }
        public int? Parentreport { get; set; }
        public string? Seriesnumber { get; set; }
        public int? Approved { get; set; }
        public bool? Approveddoctorid { get; set; }
    }
}
