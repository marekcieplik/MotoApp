using Microsoft.EntityFrameworkCore;
using MotoApp.Entites;

namespace MotoApp.Repisitories;

public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
{
    private readonly DbContext _dbContext;
    private readonly DbSet<T> _dbSet;
        
    public SqlRepository(DbContext dbContext)
    {
        _dbContext = dbContext; 
        _dbSet = dbContext.Set<T>();            
    }

    public IEnumerable<T> GetAll() => _dbSet.ToList();

    public T GetById(int id) => _dbSet.Find(id);

    public void Add(T item) => _dbSet.Add(item);

    public void Remove(T item) => _dbSet.Remove(item);

    public void Save() => _dbContext.SaveChanges();
}
