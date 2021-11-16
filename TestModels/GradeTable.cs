using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class GradeTable
    {
        public GradeTable()
        {
            GradeStreams = new HashSet<GradeStream>();
            PupilsTables = new HashSet<PupilsTable>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public int PosId { get; set; }

        public virtual GradePositionsTable Pos { get; set; }
        public virtual ICollection<GradeStream> GradeStreams { get; set; }
        public virtual ICollection<PupilsTable> PupilsTables { get; set; }
    }
}
