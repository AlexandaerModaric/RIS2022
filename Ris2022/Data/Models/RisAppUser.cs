using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Ris2022.Data.Models;

// Add profile data for application users by adding properties to the RisAppUser class
public class RisAppUser : IdentityUser
{
    public int? Languageid { get; set; } = 1;
    public string? Firstname { get; set; } = "user";
    public string? Lastname { get; set; } = "user";
    public int? Departmentid { get; set; }
    public bool? Isdoctor { get; set; } = false;
}

