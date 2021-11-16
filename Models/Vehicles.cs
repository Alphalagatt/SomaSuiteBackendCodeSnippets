using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomaSuiteBackEnd.Models
{
    public class Vehicles
    {
        [Key]
        public string VehicleRegNo { get; set; }
        public string VehicleMake { get; set; }
        public string Model { get; set; }

        [ForeignKey("Staff1")]
        public string Driver { get; set; }
        public Staff Staff1 { get; set; }

        [ForeignKey("Staff2")]
        public string Attendant { get; set; }
        public Staff Staff2 { get; set; }
        public int CarringCapacity { get; set; }
        public ICollection<Routes> RoutesAccessed { get; set; }


    }
}