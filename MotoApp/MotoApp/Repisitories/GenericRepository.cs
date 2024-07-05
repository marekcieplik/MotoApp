using MotoApp.Entites;

namespace MotoApp.Repisitories
{
    public class GenericRepository<T> 
        where T : class, IEntity, new()
    {
        public T CreateNewItem()
        {
            return new T();  //this is possible becouse T has new()
        }

        protected readonly List<T> _items = new ();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public T GetById(int id)
        {
            if (id > _items.Count)
                {
                return default(T); //return null is possible when : where T : class

                }
            else
                {
                return _items.Single(item => item.Id == id);
                }
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
