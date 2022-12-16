using CallLogSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CallLogSystem.DataContext
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<CallLog> CallLogs { get; set; }
    }
}
