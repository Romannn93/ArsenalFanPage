using ArsenalFanPage.Models;
using Microsoft.EntityFrameworkCore;

namespace ArsenalFanPage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<DetailsPlayer> DetailsPlayers { get; set; }
		public DbSet<DetailsMatch> DetailsMatch { get; set; }
	}
}
