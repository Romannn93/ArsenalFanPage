using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IMatchRepository : IRepository<Match>
    {
        void Update(Match obj);
    }
}
