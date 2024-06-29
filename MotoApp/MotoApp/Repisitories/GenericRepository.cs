using MotoApp.Entites;

namespace MotoApp.Repisitories
{
    public class GenericRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new ();

        public void Add(T item)
        {
            //employee.Id = _employees.Count + 1;
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        public Employee GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
    }
}
