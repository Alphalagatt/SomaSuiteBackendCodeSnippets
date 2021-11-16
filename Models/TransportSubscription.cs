using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class TransportSubscription
    {
        [Key]
        public int SubscritionID { get; set; }
        [ForeignKey("Route")]
        public int RouteID { get; set; }
        public Routes Route { get; set; }
        public DateTime SubscritionStartDate { get; set; }
        public int SubscriptionDuration { get; set; }
        public DateTime SubscriptionEndDate { get{ return SubscritionStartDate.AddDays(SubscriptionDuration); }  }

        [ForeignKey("Pupil")]
        public string PupilsID { get; set; }
        public Pupils Pupil { get; set; }
        public int NumberOfTripsADay { get; set; }
        public bool SubscriptionStatus { get { if (SubscriptionEndDate > DateTime.Now) { return false; } else { return true; }  } }

        public string User { get; set; }
    }
}