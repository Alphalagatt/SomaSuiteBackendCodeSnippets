using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class Guardians
    { 
        public string ParentName { get; set; }
        [Key]
        public string NationalID { get; set; }
        public string Photo { get; set; }
        public ICollection<Pupils> Pupil { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }

    }
}