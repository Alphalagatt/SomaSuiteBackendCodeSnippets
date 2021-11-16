using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class DisbursmentsTable
    {
        public DisbursmentsTable()
        {
            DisbursmentDetailsTables = new HashSet<DisbursmentDetailsTable>();
        }

        public int DisbursmentRecordId { get; set; }
        public string PupilId { get; set; }

        public virtual PaymentRecordsTable DisbursmentRecord { get; set; }
        public virtual ICollection<DisbursmentDetailsTable> DisbursmentDetailsTables { get; set; }
    }
}
