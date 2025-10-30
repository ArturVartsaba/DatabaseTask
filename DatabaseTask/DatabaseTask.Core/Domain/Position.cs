using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Position
    {
        [Key]
        public Guid Id { get; set; }
        public string PositionName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public IEnumerable<Employee> EmployeeId { get; set; }
        //    = new List<Employee>();
    }
}
