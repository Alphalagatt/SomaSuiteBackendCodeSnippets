using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomaSuiteBackEnd.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }

        [ForeignKey("CurrentYearsClass")]
        public int posID { get; set; }
        public GradePositions CurrentYearsClass { get; set; }
        public ICollection<Stream> Streams { get; set; }
        public ICollection<Pupils> PupilsOfClass { get; set; }

    }
    public class Stream
    {
        public int StreamID { get; set; }
        public string StreamName { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
    public class GradePositions
    {
        [Key]
        public int posID { get; set; }
        public string NameOfGrade { get; set; }
    }
}