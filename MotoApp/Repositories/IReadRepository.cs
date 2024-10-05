
using MotoApp.Entities;

namespace MotoApp.Repositories;

public interface IReadRepository<T> where T : class, IEntity
{
    IEnumerable<T> GetAll();

    T? GetById(int id);

}
