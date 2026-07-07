using Microsoft.EntityFrameworkCore;
using TripShare.API.Models;

namespace TripShare.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
