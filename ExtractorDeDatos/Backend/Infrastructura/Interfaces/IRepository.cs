namespace Backend.Infrastructura.Interfaces
{
    public interface IRepository<T> : IReadDataRepository<T>, IWriteDataRepository<T> where T : class { }
}
