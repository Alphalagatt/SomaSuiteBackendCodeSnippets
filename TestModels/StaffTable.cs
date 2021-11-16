using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class StaffTable
    {
        public StaffTable()
        {
            RoleStaffs = new HashSet<RoleStaff>();
            VehiclesTableAttendantNavigations = new HashSet<VehiclesTable>();
            VehiclesTableDriverNavigations = new HashSet<VehiclesTable>();
        }

        public string StaffId { get; set; }
        public string FullName { get; set; }
        public string NationalIdno { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<RoleStaff> RoleStaffs { get; set; }
        public virtual ICollection<VehiclesTable> VehiclesTableAttendantNavigations { get; set; }
        public virtual ICollection<VehiclesTable> VehiclesTableDriverNavigations { get; set; }
    }
}
