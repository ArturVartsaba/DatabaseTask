using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskBbContext : DbContext
    {
        public DatabaseTaskBbContext(DbContextOptions<DatabaseTaskBbContext> options) 
        : base(options) { }

        public DbSet<Department> Department { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Visit> Visit { get; set; }
    }
}
