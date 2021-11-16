using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class DisbursmentDetailsTable
    {
        public int DisbursmentId { get; set; }
        public int PaymentId { get; set; }
        public int StructureId { get; set; }
        public string AccountNumber { get; set; }
        public int Amount { get; set; }
        public int? DisbursmentsDisbursmentRecordId { get; set; }

        public virtual AccountsTable AccountNumberNavigation { get; set; }
        public virtual DisbursmentsTable DisbursmentsDisbursmentRecord { get; set; }
        public virtual StructuresTable Structure { get; set; }
    }
}
