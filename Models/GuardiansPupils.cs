using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SomaSuiteBackEnd.Models
{
    public class GuardiansPupils
    {
        [Key]
        [Column(Order = 0)]
        public string GuardiansNationalID { get; set; }
        [Key]
        [Column(Order = 1)]
        public string PupilRegNo { get; set; }
    }
}
