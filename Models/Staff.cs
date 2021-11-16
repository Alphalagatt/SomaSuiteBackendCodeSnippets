using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SomaSuiteBackEnd.Models
{
    public class Staff
    { 
        [Key]
        public string StaffID { get; set; }
        public string FullName { get; set; }
        public string NationalIDNo { get; set; }
        public string Photo { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}