using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Martialstatus
    {
        public int Id { get; set; }
        public string? Namear { get; set; }
        public string? Nameen { get; set; }
        public ICollection<Patient> patients { get; set; }

    }
}
