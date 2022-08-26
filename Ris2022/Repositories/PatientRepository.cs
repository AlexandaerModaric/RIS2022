using Microsoft.EntityFrameworkCore;
using Ris2022.Data;
using Ris2022.Data.Models;
using Ris2022.Interfaces;

namespace Ris2022.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(RisDBContext context) : base(context)
        {
        }
        public IEnumerable<Patient> GetPopularPatients(int count)
        {
            return _context.Patients.OrderByDescending(d => d.Firstname).Take(count).ToList();
        }
    }
}
