namespace ArsenalFanPage.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPlayerRepository Player { get; }
        IMatchRepository Match { get; }
		IDetailsMatchRepository DetailsMatch { get; }
		IHistoryRepository History { get; }
        IDetailsHistoryRepository DetailsHistory { get; }
		IDetailsNewsRepository DetailsNews { get; }
		INewsRepository News { get; }
		void Save();
    }
}
