using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class PaymentRecords
    {
        [Key]
        public int PaymentID { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentCode { get; set; }
        [ForeignKey("Account")]
        public string AccountNumber { get; set; }
        public Accounts Account { get; set; }
        [Timestamp]
        public byte[] TimeOfPayment { get; set; }
        public int Amount { get; set; }        
    }
}