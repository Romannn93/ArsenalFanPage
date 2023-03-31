using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class DetailsMatchRepository : Repository<DetailsMatch>, IDetailsMatchRepository
	{
        private ApplicationDbContext _db;
        public DetailsMatchRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(DetailsMatch obj)
        {
            _db.DetailsMatch.Update(obj);
        }
    }
}
