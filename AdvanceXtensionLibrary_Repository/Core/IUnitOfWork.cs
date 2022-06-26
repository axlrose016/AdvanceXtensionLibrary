using AdvanceXtensionLibrary_Repository.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        int Complete();
    }
}
