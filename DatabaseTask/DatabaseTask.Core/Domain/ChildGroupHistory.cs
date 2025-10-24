using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class ChildGroupHistory
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public IEnumerable<Child> Child { get; set; }
            = new List<Child>();

        public IEnumerable<Group> Group { get; set; }
            = new List<Group>();
    }
}
