using SomaSuiteBackEnd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SomaSuiteBackEnd.Models
{
    public class Accounts
    {
        
        [Key]
        [ForeignKey("Pupil")]
        public string AccountID { get; set; }
        public Pupils Pupil { get; set; }
        public ICollection<DisbursmentDetails> AllDisbursments { get; set; }
        public ICollection<PaymentRecords> AllPayments { get; set; }
        public int AmountPaid { get { return  getAmountPaid(); } }
        public int AmountUsed { get { return getAmountUsed(); } }
        public int Balances { get { return getBalances(); } }


        public int getAmountPaid()
        {
            return AllPayments.Sum(ap => ap.Amount);
        }
        public int getAmountUsed()
        {
            return AllDisbursments.Sum(ad => ad.Amount);
        }
        public int getBalances()
        {
            return getAmountPaid() - getAmountUsed();
        }

    }
    
}