using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ris2022.Data.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        [ForeignKey("patientFK")]
        public int Patientid { get; set; }

        public Patient patient { get; set; }

        [ForeignKey("ModalityFK")]
        public int Modalityid { get; set; }

        public Modality modality { get; set; }
        [ForeignKey("ProceduretypeFK")]
        public int? Proceduretypeid { get; set; }

        public Proceduretype proceduretype { get; set; }
        public string Studyid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Statusid { get; set; }
        public int? Doctorid { get; set; }
        public DateTime? Autoexpiredate { get; set; }
        public int? Accessionnumber { get; set; }
        [ForeignKey("DepartmentFK")]
        public int? Deptid { get; set; }

        public Department dept { get; set; }
        public int? Documentid { get; set; }
        [ForeignKey("OrdertypeFK")]
        public int?  Ordertypeid{ get; set; }
        public Ordertype Ordertype { get; set; }

        public DateTime? Insertdate { get; set; } = DateTime.Now;
        public int? Insertuserid { get; set; }
        [ForeignKey("ReasonFK")]
        public int? Reasonid { get; set; }

        public Reason reason { get; set; }

        public int? Updateuserid { get; set; }
        public DateTime? Updatedate { get; set; }= DateTime.Now;
        [ForeignKey("PaytypeFK")]
        public int? Paytypeid { get; set; }
        public Paytype paytype { get; set; }

        public int? Payreasonid { get; set; }

        public int? Clinicid { get; set; }


        [ForeignKey("ModalitytypeFK")]
        public int? Modalitytypeid { get; set; }

        public Modalitytype modalitytype { get; set; }
    }
}
