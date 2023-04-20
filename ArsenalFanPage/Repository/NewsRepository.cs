using ArsenalFanPage.Data;
using ArsenalFanPage.Models;
using ArsenalFanPage.Repository.IRepository;

namespace ArsenalFanPage.Repository
{
    public class NewsRepository : Repository<News>, INewsRepository
	{
        private ApplicationDbContext _db;
        public NewsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(News obj)
        {
            _db.News.Update(obj);
        }
    }
}
