namespace MotoApp.Repisitories;

using MotoApp.Entites;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    where T : class, IEntity
{ 

}
    //   IEnumerable<T> GetAll();
    //
    //    T GetById(int id);
    //
    //    void Add(T item); //kontrawariancja
    //
    //    void Remove(T item);  //kontrawariancja
    //
    //    void Save();  //kontrawariancja
