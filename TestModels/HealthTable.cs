using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class HealthTable
    {
        public HealthTable()
        {
            PupilsTables = new HashSet<PupilsTable>();
        }

        public int HealthId { get; set; }
        public string BloodGroup { get; set; }
        public string Allergies { get; set; }
        public string Disabilities { get; set; }
        public string LongTermConditions { get; set; }

        public virtual ICollection<PupilsTable> PupilsTables { get; set; }
    }
}
