using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}