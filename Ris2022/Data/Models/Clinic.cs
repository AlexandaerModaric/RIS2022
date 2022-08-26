using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Clinic
    {
        public int Id { get; set; }
        public string Namear { get; set; } = null!;
        public string? Nameen { get; set; }
        public int? Cost { get; set; }
    }
}
