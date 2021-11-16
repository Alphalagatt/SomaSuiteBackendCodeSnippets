using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class Structures
    {
        [Key]
        public int StructureID { get; set; }
        public string StructureName { get; set; }
        public ICollection<Pupils> AllPupils { get; set; }
        public ICollection<StructureDetails> Details { get; set; }
        public int TotalAmount { get { return Details.Sum(d => d.Amount); } }



    }
}