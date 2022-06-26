using AdvanceXtensionLibrary_Repository.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext(DbContextOptions<PlutoContext> opts) : base(opts) { }
        public virtual DbSet<StudentPersonalInfo> StudentPersonalInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){}
    }
}
