﻿using Ris2022.Resources;
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
        [Display( ResourceType = typeof(Resource), Name = "Proceduretype")]
        public string Namear { get; set; } = null!;
        [Required]
        [StringLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Proceduretype")]
        public string? Nameen { get; set; }
    }
}
