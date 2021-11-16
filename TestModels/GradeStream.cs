using System;
using System.Collections.Generic;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class GradeStream
    {
        public int GradesGradeId { get; set; }
        public int StreamsStreamId { get; set; }

        public virtual GradeTable GradesGrade { get; set; }
        public virtual StreamTable StreamsStream { get; set; }
    }
}
