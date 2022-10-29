using Ris2022.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ris2022.Data.Models
{
    public partial class Paytype
    {
        [Key]
        public int Id { get; set; }
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
