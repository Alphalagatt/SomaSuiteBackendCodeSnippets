using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class StreamTable
    {
        public StreamTable()
        {
            GradeStreams = new HashSet<GradeStream>();
            PupilsTables = new HashSet<PupilsTable>();
        }

        public int StreamId { get; set; }
        public string StreamName { get; set; }

        public virtual ICollection<GradeStream> GradeStreams { get; set; }
        public virtual ICollection<PupilsTable> PupilsTables { get; set; }
    }
}
