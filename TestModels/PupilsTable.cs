using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class PupilsTable
    {
        public PupilsTable()
        {
            GuardiansPupils = new HashSet<GuardiansPupil>();
            PupilsStructures = new HashSet<PupilsStructure>();
            TransportSubscriptions = new HashSet<TransportSubscription>();
        }

        public string PupilRegNo { get; set; }
        public string PupilFullName { get; set; }
        public string Gender { get; set; }
        public int? GradeId { get; set; }
        public int? StreamId { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Doa { get; set; }
        public string Photo { get; set; }
        public int? HealthId { get; set; }

        public virtual GradeTable Grade { get; set; }
        public virtual HealthTable Health { get; set; }
        public virtual StreamTable Stream { get; set; }
        public virtual AccountsTable AccountsTable { get; set; }
        public virtual ICollection<GuardiansPupil> GuardiansPupils { get; set; }
        public virtual ICollection<PupilsStructure> PupilsStructures { get; set; }
        public virtual ICollection<TransportSubscription> TransportSubscriptions { get; set; }
    }
}
