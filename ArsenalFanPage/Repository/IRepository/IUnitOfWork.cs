namespace ArsenalFanPage.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPlayerRepository Player { get; }
        IMatchRepository Match { get; }
		IDetailsMatchRepository DetailsMatch { get; }
		void Save();
    }
}
