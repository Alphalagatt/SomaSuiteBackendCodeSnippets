using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class VehiclesTable
    {
        public VehiclesTable()
        {
            RoutesVehicles = new HashSet<RoutesVehicle>();
        }

        public string VehicleRegNo { get; set; }
        public string VehicleMake { get; set; }
        public string Model { get; set; }
        public string Driver { get; set; }
        public string Attendant { get; set; }
        public int CarringCapacity { get; set; }

        public virtual StaffTable AttendantNavigation { get; set; }
        public virtual StaffTable DriverNavigation { get; set; }
        public virtual ICollection<RoutesVehicle> RoutesVehicles { get; set; }
    }
}
