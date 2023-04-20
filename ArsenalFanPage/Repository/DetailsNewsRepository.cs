using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class DetailsNewsRepository : Repository<DetailsNews>, IDetailsNewsRepository
	{
        private ApplicationDbContext _db;
        public DetailsNewsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(DetailsNews obj)
        {
            _db.DetailsNews.Update(obj);
        }
    }
}
