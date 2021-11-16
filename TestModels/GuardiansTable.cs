using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class GuardiansTable
    {
        public GuardiansTable()
        {
            GuardiansPupils = new HashSet<GuardiansPupil>();
        }

        public string NationalId { get; set; }
        public string ParentName { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Dob { get; set; }

        public virtual ICollection<GuardiansPupil> GuardiansPupils { get; set; }
    }
}
