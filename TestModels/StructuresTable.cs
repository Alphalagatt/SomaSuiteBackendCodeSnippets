using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class StructuresTable
    {
        public StructuresTable()
        {
            DisbursmentDetailsTables = new HashSet<DisbursmentDetailsTable>();
            PupilsStructures = new HashSet<PupilsStructure>();
            StructureDetailsTables = new HashSet<StructureDetailsTable>();
        }

        public int StructureId { get; set; }
        public string StructureName { get; set; }

        public virtual ICollection<DisbursmentDetailsTable> DisbursmentDetailsTables { get; set; }
        public virtual ICollection<PupilsStructure> PupilsStructures { get; set; }
        public virtual ICollection<StructureDetailsTable> StructureDetailsTables { get; set; }
    }
}
