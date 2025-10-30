using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<Group> Groups { get; set; } = new List<Group>();
    }
}
