using Ris2022.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ris2022.Data.Models
{
    public partial class Modality
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(25)]
        
        [Display( ResourceType = typeof(Resource), Name = "Modality")]
        public string? Name { get; set; }
        
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "AETitle")]
        public string? Aetitle { get; set; }
        
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "IpAddress")]
        public string? Ipaddress { get; set; }

        [Required]
        [Range(1024, 65536)]
        [Display(ResourceType = typeof(Resource), Name = "Port")]
        public int? Port { get; set; }

        [Required]
        [ForeignKey(nameof(Modalitytype))]
        public int? Modalitytypeid { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "Modalitytype")]
        public virtual Modalitytype? Modalitytype { get; set; }

        [StringLength(200)]
        [Display(ResourceType = typeof(Resource), Name = "Description")]
        public string? Description { get; set; }

        [Required]
        [ForeignKey(nameof(Department))]
        public int? Departmentid { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "Department")]
        public virtual Department? Department { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }

    }
}
