using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class AccountsTable
    {
        public AccountsTable()
        {
            DisbursmentDetailsTables = new HashSet<DisbursmentDetailsTable>();
            PaymentRecordsTables = new HashSet<PaymentRecordsTable>();
        }

        public string AccountId { get; set; }

        public virtual PupilsTable Account { get; set; }
        public virtual ICollection<DisbursmentDetailsTable> DisbursmentDetailsTables { get; set; }
        public virtual ICollection<PaymentRecordsTable> PaymentRecordsTables { get; set; }
    }
}
