using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SomaSuiteBackEnd.Models
{
    public class Routes
    {
        [Key]
        public int routeID { get; set; }
        public string RouteName { get; set; }
        public int PricePerMonth { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; }

        public DateTime timeOfCollection { get; set; }
    }
}