using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskBbContext : DbContext
    {
        public DatabaseTaskBbContext(DbContextOptions<DatabaseTaskBbContext> options) 
        : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
