using MotoApp.Entities;

namespace MotoApp.Repositories;

public interface IWriteRepository<T> where T : class, IEntity
{
    void Add(T item);

    void Remove(T item);

    void Save();

}
