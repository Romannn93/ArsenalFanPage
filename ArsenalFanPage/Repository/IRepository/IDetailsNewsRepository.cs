using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IDetailsNewsRepository : IRepository<DetailsNews>
    {
        void Update(DetailsNews obj);
    }
}
