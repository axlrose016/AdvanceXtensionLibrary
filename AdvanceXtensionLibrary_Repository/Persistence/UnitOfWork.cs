using AdvanceXtensionLibrary_Repository.Core;
using AdvanceXtensionLibrary_Repository.Core.Repositories;
using AdvanceXtensionLibrary_Repository.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext Context;
        public UnitOfWork(PlutoContext _context)
        {
            Context = _context;
            Students = new StudentRepository(Context);
        }
        public IStudentRepository Students { get; private set; }

        public int Complete()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
