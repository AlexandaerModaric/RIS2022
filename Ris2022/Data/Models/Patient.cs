using Ris2022.Services;
using System.ComponentModel.DataAnnotations;
using Ris2022.Resources;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ris2022.Data.Models
{
    public enum gender
    {
        Male=0,
        Female=1
    }
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "PatId")]
        public string Givenid { get; set; } = null!;
        //[Required]
        //[DataType(DataType.PhoneNumber)]
        //[StringLength(11, ErrorMessage = "The National id  length is 11 characters.")]
        //[MinLength(11, ErrorMessage = "The National id length  is 11 characters.")]
        //public string Nationalidnumber { get; set; } = null!;
        [Required]
        [MaxLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "Name")]
        public string Firstname { get; set; } = null!;

        [MaxLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "FathName")]
        public string? Middlename { get; set; }
        [MaxLength(25)]
        [Display(ResourceType = typeof(Resource), Name = "SurName")]
        public string Lastname { get; set; } = null!;

        [Range(0, 1)]
        [Display(ResourceType = typeof(Resource), Name = "Gender")]
        public gender Gendre { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "MotherName")]
        public string? Mothername { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Birthdate")]
        public DateTime? Birthdate { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Age")]
        public int? Age { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Mobilephone")]
        public string? Mobilephone { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Landphone")]
        public string? Landphone { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Currentaddress")]
        public string? Currentaddress { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Residentaddress")]
        public string? Residentaddress { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Workphone")]
        public string? Workphone { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Workaddress")]
        public string? Workaddress { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Nearestperson")]
        public string? Nearestperson { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Nearestpersonphone")]
        public string? Nearestpersonphone { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Birthplace")]
        public string? Birthplace { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Notes")]
        public string? Notes { get; set; }

        public string? Translatedfname { get; set; }
        public string? Translatedlname { get; set; }
        public string? Translatedfathername { get; set; }
        public string? Translatedmothername { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Insertdate")]
        public DateTime? Insertdate { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "UpdateuserName")]
        public string? UpdateuserName { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Updatedate")]
        public DateTime? Updatedate { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Reason")]
        public int? Reasonid { get; set; }
        public virtual Reason? Reason { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "InsertUserName")]
        public string InsertUserName { get; set; }

        [ForeignKey("NationalityFK")]
        [Display(ResourceType = typeof(Resource), Name = "Nationality")]
        public int? Nationalityid { get; set; }
        public virtual Nationality? Nationality { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Worktype")]
        [ForeignKey("WorktypeFK")]
        public int? Worktypeid { get; set; }
        public virtual Worktype? Worktype { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Martialstatus")]
        [ForeignKey("MartialstatusFK")]
        public int? Martialstatusid { get; set; }
        public virtual Martialstatus? Martialstatus { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Acceptancetype")]
        [ForeignKey("AcceptancetypeFK")]
        public int Acceptancetypeid { get; set; }
        public virtual Acceptancetype? Acceptancetype { get; set; }

        public virtual ICollection<Order>? patientOrders { get; set; }
    }
}
