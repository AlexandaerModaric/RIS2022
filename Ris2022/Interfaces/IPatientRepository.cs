using Ris2022.Data.Models;
using Ris2022.Repositories;

namespace Ris2022.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        IEnumerable<Patient> GetPopularPatients(int count);
    }
}
