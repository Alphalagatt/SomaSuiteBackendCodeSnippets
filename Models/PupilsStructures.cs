using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SomaSuiteBackEnd.Models
{
    public class PupilsStructures
    {
        [Key]
        [Column(Order = 0)]
        public string AllPupilsPupilRegNo { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentStructuresStructureID { get; set; }
    }
}
