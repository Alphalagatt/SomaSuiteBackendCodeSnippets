using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SomaSuiteBackEnd.Models
{
    public class RoutesVehicles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoutesAccessedRouteID { get; set; }
        [Key]
        [Column(Order = 1)]
        public string VehiclesVehicleRegNo { get; set; }
    }
}
