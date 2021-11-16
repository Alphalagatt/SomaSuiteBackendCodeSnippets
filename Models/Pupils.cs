using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Web;


namespace SomaSuiteBackEnd.Models
{
    public class Pupils
    {
        
        [Key]
        public string PupilRegNo { get; set; }
        public string PupilFullName { get; set; }
        public string Gender { get; set; }
        [ForeignKey("PupilsGrade")]
        public int? GradeID { get; set; }
        public Grade PupilsGrade { get; set; }
        [ForeignKey("PupilsStream")]
        public int? StreamID { get; set; }
        public Stream PupilsStream { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOA { get; set; }
        public string Photo { get; set; }

        [ForeignKey("HealthConditions")]
        public int? HealthID { get; set; }
        public Health HealthConditions { get; set; }
        public ICollection<Guardians> Guardians { get; set; }
        public ICollection<Structures> PaymentStructures { get; set; }

    }
}