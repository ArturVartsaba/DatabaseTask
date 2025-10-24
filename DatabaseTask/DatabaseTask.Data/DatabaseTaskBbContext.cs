using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskBbContext : DbContext
    {
        public DatabaseTaskBbContext(DbContextOptions<DatabaseTaskBbContext> options) 
        : base(options) { }

        public DbSet<Child> Child { get; set; }
        public DbSet<ChildAbsence> ChildAbsence { get; set; }
        public DbSet<ChildGroupHistory> ChildGroupHistory { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Queue> Queue { get; set; }
    }
}
