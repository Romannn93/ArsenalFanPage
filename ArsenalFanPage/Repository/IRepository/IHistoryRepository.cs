using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IHistoryRepository : IRepository<History>
    {
        void Update(History obj);
    }
}
