using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class PupilsStructure
    {
        public string AllPupilsPupilRegNo { get; set; }
        public int PaymentStructuresStructureId { get; set; }

        public virtual PupilsTable AllPupilsPupilRegNoNavigation { get; set; }
        public virtual StructuresTable PaymentStructuresStructure { get; set; }
    }
}
