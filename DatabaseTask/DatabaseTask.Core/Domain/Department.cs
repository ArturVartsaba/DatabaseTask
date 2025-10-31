using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid ID { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string LeadDoctor { get; set; } = string.Empty;
        public ICollection<Doctor> Doctors { get; set; }
            = new List<Doctor>();
        public string Aadress { get; set; } = string.Empty;
        public int ContactNumber { get; set; }
    }
}
