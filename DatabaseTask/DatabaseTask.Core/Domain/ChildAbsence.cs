using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class ChildAbsence
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;

        public IEnumerable<Group> Groups { get; set; }
            = new List<Group>();

        public IEnumerable<Child> Childs { get; set; }
            = new List<Child>();
    }
}
