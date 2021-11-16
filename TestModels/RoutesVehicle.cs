using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class RoutesVehicle
    {
        public int RoutesAccessedrouteId { get; set; }
        public string VehiclesVehicleRegNo { get; set; }

        public virtual RoutesTable RoutesAccessedroute { get; set; }
        public virtual VehiclesTable VehiclesVehicleRegNoNavigation { get; set; }
    }
}
