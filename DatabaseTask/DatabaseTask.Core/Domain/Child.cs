using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public Guid ChildID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
