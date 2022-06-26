using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Core.Domain
{
    public class StudentPersonalInfo
    {
        [Key]
        public int Student_Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Adrs1 { get; set; }
        public string Adrs2 { get; set; }
        public string ContactNo { get; set; }
    }
}
