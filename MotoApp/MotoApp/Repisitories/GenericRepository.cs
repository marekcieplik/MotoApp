using MotoApp.Entites;

namespace MotoApp.Repisitories
{
    public class GenericRepository<TEntity, TKey> 
        where TEntity : class, IEntity, new()  //new() means that class should have NoArgs Constructor
        where TKey : struct  //struct means that could by types which are struct, e.g. int
    {
        public TEntity CreateNewItem()
        {
            return new TEntity();  //this is possible becouse TEntity has new()
        }
        public TKey? Key { get; set; }
        protected readonly List<TEntity> _items = new ();

        public void Add(TEntity item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public TEntity GetById(int id)
        {
            if (id > _items.Count)
                {
                return default(TEntity); //return null is possible when : where TEntity : class

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
