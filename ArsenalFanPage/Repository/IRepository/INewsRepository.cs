using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface INewsRepository : IRepository<News>
    {
        void Update(News obj);
    }
}
