using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Queue
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly RegDate { get; set; }

        public IEnumerable<Child> Child { get; set; }
            = new List<Child>();

        public IEnumerable<Group> Group { get; set; }
            = new List<Group>();
    }
}
