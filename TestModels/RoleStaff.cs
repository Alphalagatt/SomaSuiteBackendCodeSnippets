using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class RoleStaff
    {
        public int RolesRoleId { get; set; }
        public string StaffsStaffId { get; set; }

        public virtual RolesTable RolesRole { get; set; }
        public virtual StaffTable StaffsStaff { get; set; }
    }
}
