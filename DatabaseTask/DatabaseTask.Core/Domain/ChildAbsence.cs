using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class ChildAbsence
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;

        public IEnumerable<Child> Child { get; set; }
            = new List<Child>();

        public IEnumerable<Group> Group { get; set; }
            = new List<Group>();
    }
}
