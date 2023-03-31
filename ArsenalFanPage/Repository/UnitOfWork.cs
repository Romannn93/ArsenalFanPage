using ArsenalFanPage.Data;
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
        }
        public IPlayerRepository Player { get; private set; }
        public IMatchRepository Match { get; private set; }
        public IDetailsMatchRepository DetailsMatch { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
