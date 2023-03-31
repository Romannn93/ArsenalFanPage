using ArsenalFanPage.Models;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IPlayerRepository : IRepository<Player>
    {
        void Update(Player obj);
    }
}
