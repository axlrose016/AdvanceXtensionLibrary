using AdvanceXtensionLibrary_Repository.Core.Domain;
using AdvanceXtensionLibrary_Repository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Persistence.Repositories
{
    public class StudentRepository : Repository<StudentPersonalInfo>, IStudentRepository
    {
        public StudentRepository(PlutoContext _context) : base(_context) { }
        public async Task<IEnumerable<StudentPersonalInfo>> GetStudentByBranch(int branchId)
        {
            return await PlutoContext.StudentPersonalInfo.Where(w => w.Student_Id == branchId).ToListAsync();
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
