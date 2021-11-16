using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class PaymentRecordsTable
    {
        public int PaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentCode { get; set; }
        public string AccountNumber { get; set; }
        public byte[] TimeOfPayment { get; set; }
        public int Amount { get; set; }

        public virtual AccountsTable AccountNumberNavigation { get; set; }
        public virtual DisbursmentsTable DisbursmentsTable { get; set; }
    }
}
