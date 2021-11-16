using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class TransportSubscription
    {
        public int SubscritionId { get; set; }
        public int RouteId { get; set; }
        public DateTime SubscritionStartDate { get; set; }
        public int SubscriptionDuration { get; set; }
        public string PupilsId { get; set; }
        public int NumberOfTripsAday { get; set; }
        public string User { get; set; }

        public virtual PupilsTable Pupils { get; set; }
        public virtual RoutesTable Route { get; set; }
    }
}
