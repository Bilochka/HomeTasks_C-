using System.Data.Entity;

namespace HT9_EF6
{
    public class SoccerContext : DbContext
    {
        public SoccerContext()
            : base("dbconnection")
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}