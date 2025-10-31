using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid ID { get; set; }
        public string IdentityCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; } = string.Empty;
        public ICollection<Visit> Visits { get; set; }
            = new List<Visit>();
    }
}
