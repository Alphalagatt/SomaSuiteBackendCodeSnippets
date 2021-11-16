using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class GuardiansPupil
    {
        public string GuardiansNationalId { get; set; }
        public string PupilRegNo { get; set; }

        public virtual GuardiansTable GuardiansNational { get; set; }
        public virtual PupilsTable PupilRegNoNavigation { get; set; }
    }
}
