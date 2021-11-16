using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class Health
    {
        [Key]
        public int HealthID { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        [DefaultValue("N/A")]
        public string Allergies { get; set; }
        [Required]
        [DefaultValue("N/A")]
        public string Disabilities { get; set; }
        [Required]
        [DefaultValue("N/A")]
        public string LongTermConditions { get; set; }


    }
}