using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public Guid ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Profession { get; set; } = string.Empty;
        public int ContactNumber { get; set; }

        public ICollection<Department> Department { get; set; }
            = new List<Department>();
    }
}
