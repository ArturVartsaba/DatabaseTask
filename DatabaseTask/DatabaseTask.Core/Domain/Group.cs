using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        public int ChildCount { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string RoomNr { get; set; } = string.Empty;

        //public IEnumerable<Employee> Employees { get; set; }
        //    = new List<Employee>();
    }
}
