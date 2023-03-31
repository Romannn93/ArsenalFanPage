using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IDetailsMatchRepository : IRepository<DetailsMatch>
    {
        void Update(DetailsMatch obj);
    }
}
