using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Language
    {
        public int Id { get; set; }
        public string Namear { get; set; } = null!;
        public string? Nameen { get; set; }
        public string Code { get; set; } = null!;
    }
}
