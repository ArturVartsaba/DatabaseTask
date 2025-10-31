using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {

        [Key]
        public Guid ID { get; set; }
        public DateTime VisitDate { get; set; }
        public string Description { get; set; } = string.Empty;

        public ICollection<Doctor> Doctor { get; set; }
            = new List<Doctor>();

        public ICollection<Patient> Patient { get; set; }
            = new List<Patient>();

        public ICollection<Medicine> Medicines { get; set; }
            = new List<Medicine>();
    }
}
