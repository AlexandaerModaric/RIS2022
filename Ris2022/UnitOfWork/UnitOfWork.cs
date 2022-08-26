using Ris2022.Data;
using Ris2022.Interfaces;

namespace Ris2022.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RisDBContext _context;
        public UnitOfWork(RisDBContext context)
        {
            _context = context;
            Patients = new PatientRepository(_context);
        }
        public IPatientRepository Patients { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
