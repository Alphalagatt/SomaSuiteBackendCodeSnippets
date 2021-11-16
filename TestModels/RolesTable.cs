using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class RolesTable
    {
        public RolesTable()
        {
            RoleStaffs = new HashSet<RoleStaff>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RoleStaff> RoleStaffs { get; set; }
    }
}
