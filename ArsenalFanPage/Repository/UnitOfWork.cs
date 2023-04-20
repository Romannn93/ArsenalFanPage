using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;
using NuGet.Configuration;

namespace ArsenalFanPage.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Player = new PlayerRepository(_db);
            Match = new MatchRepository(_db);  
            DetailsMatch = new DetailsMatchRepository(_db);
            History = new HistoryRepository(_db);
            DetailsHistory = new DetailsHistoryRepository(_db);
            News = new NewsRepository(_db);
            DetailsNews = new DetailsNewsRepository(_db);
        }
        public IPlayerRepository Player { get; private set; }
        public IMatchRepository Match { get; private set; }
        public IDetailsMatchRepository DetailsMatch { get; private set; }
        public IHistoryRepository History { get; private set; }
        public IDetailsHistoryRepository DetailsHistory { get; private set; }
        public INewsRepository News { get; private set; }
        public IDetailsNewsRepository DetailsNews { get; private set; }
		public void Save()
        {
            _db.SaveChanges();
        }
    }
}
