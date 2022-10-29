using Ris2022.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Ris2022.Data.Models
{
    public partial class Proceduretype
    {
        public int Id { get; set; }
        public int Parentnum { get; set; }
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Namear")]
        public string? Namear { get; set; }
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Nameen")]
        public string? Nameen { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
