using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        private ApplicationDbContext _db;
        public PlayerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Player obj)
        {
            _db.Players.Update(obj);
        }
    }
}
