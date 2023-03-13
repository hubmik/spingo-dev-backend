using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAL
{
    public partial class SpingoDbContext : DbContext
    {
        public SpingoDbContext()
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        public DbSet<UserDevices> UserDevices { get; set; }
    }
}
