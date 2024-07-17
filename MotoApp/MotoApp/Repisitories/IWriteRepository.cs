using MotoApp.Entites;

namespace MotoApp.Repisitories;

public interface IWriteRepository<in T> //kontrawariancja
    where T : class, IEntity
{
    void Add(T item); //kontrawariancja
    
    void Remove(T item);  //kontrawariancja
    
    void Save();  //kontrawariancja

}
