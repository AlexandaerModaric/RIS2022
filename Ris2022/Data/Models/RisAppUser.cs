using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Ris2022.Resources;

namespace Ris2022.Data.Models;

// Add profile data for application users by adding properties to the RisAppUser class
public class RisAppUser : IdentityUser
{
    [Display(ResourceType = typeof(Resource), Name = "Lang")]
    public int? Languageid { get; set; } = 1;
    [Display(ResourceType = typeof(Resource), Name = "Name")]
    public string? Firstname { get; set; } = "user";
    [Display(ResourceType = typeof(Resource), Name = "SurName")]
    public string? Lastname { get; set; } = "user";
    [Display(ResourceType = typeof(Resource), Name = "Department")]
    [ForeignKey("DepartmentFK")]
    public int? Departmentid { get; set; }

    public virtual Department? Department { get; set; }

    [Display(ResourceType = typeof(Resource), Name = "IsDoctor")]
    public bool? Isdoctor { get; set; } = false;
    public virtual ICollection<Order>? Orders { get; set; }


}

