using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IDetailsHistoryRepository : IRepository<DetailsHistory>
    {
        void Update(DetailsHistory obj);
    }
}
