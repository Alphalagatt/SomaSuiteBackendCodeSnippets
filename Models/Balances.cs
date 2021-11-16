using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomaSuiteBackEnd.Models
{
    public class Balances
    {
        [Key]
        
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Grade { get; set; }
        public string Stream { get; set; }
        public int AmountToBePaid { get; set; }
        public int AmountPaid { get; set; }
        public int Balance { get { return AmountToBePaid - AmountPaid; } }
    }
}