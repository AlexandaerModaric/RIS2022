using Ris2022.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ris2022.Data.Models
{
    public partial class Order
    {
        public int Id { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "PatId")]
        [ForeignKey("patientFK")]
        public int Patientid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "PatientName")]
        public virtual Patient? patient { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Modality")]
        [ForeignKey("ModalityFK")]
        public int Modalityid { get; set; }

        public virtual Modality? modality { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Proceduretype")]
        [ForeignKey("ProceduretypeFK")]
        public int? Proceduretypeid { get; set; }

        public virtual Proceduretype? proceduretype { get; set; }

        public string Studyid { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "StartDate")]
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Statusid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "DoctorName")]
        public string Doctorid { get; set; }
        public virtual RisAppUser? RisAppDoctor { get; set; }

        public DateTime? Autoexpiredate { get; set; }

        public int? Accessionnumber { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "Department")]
        [ForeignKey("DepartmentFK")]
        public int? Departmentid { get; set; }

        public virtual Department? dept { get; set; }
        public int? Documentid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Ordertype")]
        [ForeignKey("OrdertypeFK")]
        public int?  Ordertypeid{ get; set; }
        public virtual Ordertype? Ordertype { get; set; }

        public DateTime? Insertdate { get; set; } = DateTime.Now;
        public string? InsertuserName { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Reason")]
        [ForeignKey("ReasonFK")]
        public int? Reasonid { get; set; }

        public virtual Reason? reason { get; set; }

        public string? UpdateuserName { get; set; }
        public DateTime? Updatedate { get; set; }= DateTime.Now;

        [Display(ResourceType = typeof(Resource), Name = "Paytype")]
        [ForeignKey("PaytypeFK")]
        public int? Paytypeid { get; set; }
        public virtual Paytype? paytype { get; set; }

        public int? Payreasonid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Clinic")]
        public int? Clinicid { get; set; }
        public virtual Clinic? clinic { get; set; }


        [Display(ResourceType = typeof(Resource), Name = "Modalitytype")]
        [ForeignKey("ModalitytypeFK")]
        public int? Modalitytypeid { get; set; }

        public virtual Modalitytype? modalitytype { get; set; }
    }
}
