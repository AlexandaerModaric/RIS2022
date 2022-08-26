using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Modality
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Aetitle { get; set; }
        public string? Ipaddress { get; set; }
        public int? Port { get; set; }
        public int? Modalitytypeid { get; set; }
        public string? Description { get; set; }
        public int? Departmentid { get; set; }
    }
}
