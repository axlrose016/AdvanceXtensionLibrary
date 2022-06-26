using AdvanceXtensionLibrary_Repository.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Core.Repositories
{
    public interface IStudentRepository : IRepository<StudentPersonalInfo>
    {
        Task<IEnumerable<StudentPersonalInfo>> GetStudentByBranch(int branchId);
    }
}
