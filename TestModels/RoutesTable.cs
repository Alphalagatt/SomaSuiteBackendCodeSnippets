using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class RoutesTable
    {
        public RoutesTable()
        {
            RoutesVehicles = new HashSet<RoutesVehicle>();
            TransportSubscriptions = new HashSet<TransportSubscription>();
        }

        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int PricePerMonth { get; set; }
        public DateTime TimeOfCollection { get; set; }

        public virtual ICollection<RoutesVehicle> RoutesVehicles { get; set; }
        public virtual ICollection<TransportSubscription> TransportSubscriptions { get; set; }
    }
}
