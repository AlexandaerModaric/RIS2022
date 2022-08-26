using System;
using System.Collections.Generic;

namespace Ris2022.Data.Models
{
    public partial class Proceduretype
    {
        public int Id { get; set; }
        public int Parentnum { get; set; }
        public string? Namear { get; set; }
        public string? Nameen { get; set; }
    }
}
