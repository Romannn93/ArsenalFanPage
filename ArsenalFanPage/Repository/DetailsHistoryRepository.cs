using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class DetailsHistoryRepository : Repository<DetailsHistory>, IDetailsHistoryRepository
	{
        private ApplicationDbContext _db;
        public DetailsHistoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(DetailsHistory obj)
        {
            _db.DetailsHistories.Update(obj);
        }
    }
}
