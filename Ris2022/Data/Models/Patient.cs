using Ris2022.Services;
using System.ComponentModel.DataAnnotations;
using Ris2022.Resources;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ris2022.Data.Models
{
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

        public int? Gendre { get; set; }
        //public string? Mothername { get; set; }
        //public DateTime? Birthdate { get; set; }
        //public int? Age { get; set; }
        //public string? Mobilephone { get; set; }
        //public string? Landphone { get; set; }
        //public string? Currentaddress { get; set; }
        //public string? Residentaddress { get; set; }
        //public string? Workphone { get; set; }
        //public string? Workaddress { get; set; }
        //public string? Nearestperson { get; set; }
        //public string? Nearestpersonphone { get; set; }
        //public string? Birthplace { get; set; }

        //public string? Notes { get; set; }
        //public string? Translatedfname { get; set; }
        //public string? Translatedlname { get; set; }
        //public string? Translatedfathername { get; set; }
        //public string? Translatedmothername { get; set; }
        //public DateTime? Insertdate { get; set; }

        //public DateTime? Updatedate { get; set; }
        //public int? Reasonid { get; set; }
        public string InsertUserName { get; set; }

        [ForeignKey("NationalityFK")]
        [Display(ResourceType = typeof(Resource), Name = "Nationality")]
        public int? Nationalityid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Worktype")]
        [ForeignKey("WorktypeFK")]
        public int? Worktypeid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Martialstatus")]
        [ForeignKey("MartialstatusFK")]
        public int? Martialstatusid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Acceptancetype")]
        [ForeignKey("AcceptancetypeFK")]
        public int Acceptancetypeid { get; set; }

        public ICollection<Order> patientOrders { get; set; }
    }
}
