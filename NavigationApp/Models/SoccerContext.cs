using System.Data.Entity;

namespace NavigationApp.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}