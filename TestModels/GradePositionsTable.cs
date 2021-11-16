using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class GradePositionsTable
    {
        public GradePositionsTable()
        {
            GradeTables = new HashSet<GradeTable>();
        }

        public int PosId { get; set; }
        public string NameOfGrade { get; set; }

        public virtual ICollection<GradeTable> GradeTables { get; set; }
    }
}
