﻿using Ris2022.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Ris2022.Data.Models
{
    public partial class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Department")]
        public string Namear { get; set; } = null!;
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Department")]
        public string? Nameen { get; set; }
    }
}
