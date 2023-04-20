using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class HistoryRepository : Repository<History>, IHistoryRepository
	{
        private ApplicationDbContext _db;
        public HistoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(History obj)
        {
            _db.Histories.Update(obj);
        }
    }
}
