using MotoApp.Entities;

namespace MotoApp.Repositories;

public class ListGenericRepository<T> : IRepository<T> where T : class, IEntity, new()
{
    protected readonly List<T> _items = new List<T>();

    public IEnumerable<T> GetAll()
    {
        return _items.ToList();
    }

    public T GetById(int id)
    {
        return _items.Single(item => item.Id == id);
    }

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public void Save()
    {
       // save is not required with List
    }

    public void PrintListOnScrean()
    {
        Console.WriteLine($"class ListGenericRepository<T> : IRepository<T> where T : class, IEntity, new()");
        foreach(var item in _items)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
