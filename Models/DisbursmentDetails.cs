using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class DisbursmentDetails
    {
        [Key]
        public int disbursmentID { get; set; }
        public int PaymentID { get; set; }

        [ForeignKey("Cartegory")]
        public int StructureID { get; set; }
        public Structures Cartegory { get; set; }
        [ForeignKey("Account")]
        public string AccountNumber { get; set; }
        public Accounts Account { get; set; } 
        public int Amount { get; set; }
    }
}