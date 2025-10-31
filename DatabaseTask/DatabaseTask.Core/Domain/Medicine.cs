using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Medicine
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ingridient { get; set; } = string.Empty;
        public int Dosage { get; set; }
        public ICollection<Patient> Patients { get; set; } 
            = new List<Patient>();
    }
}
