using System;

namespace DungeonResource.Components.Repository
{
    public interface IGenericRepository<T>
    {
        T Create(T entity);
        void Delete(T entity);
        System.Collections.Generic.List<T> Read();
        T Read(int id);
        System.Collections.Generic.List<T> Read(int page, int pageSize);
        T Update(T entity);
    }
}
