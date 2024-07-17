using MotoApp.Entites;

namespace MotoApp.Repisitories;

public interface IReadRepository<out T> //kowariancja
    where T : class, IEntity
{
    IEnumerable<T> GetAll();

    T GetById(int id);
}
