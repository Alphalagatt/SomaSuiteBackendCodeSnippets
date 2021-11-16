using System.ComponentModel.DataAnnotations;

namespace SomaSuiteBackEnd.Models
{
    public class StructureDetails
    {
        [Key]
        public int StructureDetailsID { get; set; }
        public string DetailName { get; set; }
        public int Amount { get; set; }
    }
}