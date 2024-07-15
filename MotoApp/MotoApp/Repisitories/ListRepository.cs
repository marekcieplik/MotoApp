using MotoApp.Entites;

namespace MotoApp.Repisitories;

public class ListRepository<T> : IRepository<T>
    where T : class, IEntity, new()
{
    private readonly List<T> _items = new List<T>();

    public IEnumerable<T> GetAll() => _items.ToList();

    public T GetById(int id) => _items.Single(item => item.Id == id);

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public void Remove(T item) => _items.Remove(item);

    public void Save()
    {
        //save is not required with List
    }
}
