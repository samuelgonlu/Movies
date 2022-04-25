namespace BusinessLogic.Interfaces
{
    public interface IRepositoryManagerM
    {
        IMoviesRepository Movies { get; }
        void Save();
    }
}
