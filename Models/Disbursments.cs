using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class Disbursments
    {
        [Key]
        [ForeignKey("PaymentRecord")]
        [Required]
        public int DisbursmentRecordID { get; set; }
        public PaymentRecords PaymentRecord { get; set; }
        public string PupilID { get; set; }
        public ICollection<DisbursmentDetails> DisbursmentDetail { get; set; }
        public int TotalAmountDisbursed { get { return getTotalAmount(); } }

        private int getTotalAmount()
        {
            int totalAmountDisbursed;
            totalAmountDisbursed = DisbursmentDetail.Sum(tad => tad.Amount);
            return totalAmountDisbursed;
        }

    }
}