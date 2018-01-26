//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace FirstEF6App_Code_First
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