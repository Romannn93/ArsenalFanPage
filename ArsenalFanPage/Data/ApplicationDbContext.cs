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
		public DbSet<History> Histories { get; set; }
		public DbSet<DetailsHistory> DetailsHistories{ get; set; }
        public DbSet<News> News { get; set; }
		public DbSet<DetailsNews> DetailsNews { get; set; }
	}
}
