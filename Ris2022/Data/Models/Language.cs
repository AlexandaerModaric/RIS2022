using Ris2022.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Ris2022.Data.Models
{
    public partial class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Lang")]
        public string Namear { get; set; } = null!;
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Lang")]
        public string? Nameen { get; set; }
        public string Code { get; set; } = null!;
    }
}
