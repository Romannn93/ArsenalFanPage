using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class MatchRepository : Repository<Match>, IMatchRepository
    {
        private ApplicationDbContext _db;
        public MatchRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Match obj)
        {
            _db.Matches.Update(obj);
        }
    }
}
