using MotoApp.Entities;

namespace MotoApp.Repositories;

public class ListGenericRepository<T> where T : IEntity
{
    protected readonly List<T> _entities = new List<T>();

    public void Add(T entity)
    {
        entity.Id = _entities.Count + 1;
        _entities.Add(entity);
    }

    public T GetById(int id)
    {
        return _entities.Single(entity => entity.Id == id);
    }

    public void Save()
    {
        foreach (var entity in _entities)
        {
            Console.WriteLine(entity.ToString());
        }
    }
}
