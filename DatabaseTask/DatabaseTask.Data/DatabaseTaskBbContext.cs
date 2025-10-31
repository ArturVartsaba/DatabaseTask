using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskBbContext : DbContext
    {
        public DatabaseTaskBbContext(DbContextOptions<DatabaseTaskBbContext> options) 
        : base(options) { }

        
    }
}
