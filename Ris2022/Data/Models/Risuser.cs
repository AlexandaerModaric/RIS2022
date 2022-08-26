using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Risuser
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public int? Languageid { get; set; } = 1;
        public int? Userroleid { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? Departmentid { get; set; }
        public bool? Isdoctor { get; set; } = false;
    }
}
