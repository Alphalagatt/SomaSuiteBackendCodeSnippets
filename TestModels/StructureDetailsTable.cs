using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class StructureDetailsTable
    {
        public int StructureDetailsId { get; set; }
        public string DetailName { get; set; }
        public int Amount { get; set; }
        public int? StructuresStructureId { get; set; }

        public virtual StructuresTable StructuresStructure { get; set; }
    }
}
