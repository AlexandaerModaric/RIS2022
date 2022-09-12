using Ris2022.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ris2022.Data.ViewModel
{
    public class PatientViewModel
    {
        public ICollection<Nationality> nationalities { get; set; }
        public ICollection<Worktype> worktypes { get; set; }
        public ICollection<Martialstatus> martialstatuses { get; set; }
        public ICollection<Acceptancetype> acceptancetypes { get; set; }

    }
}
