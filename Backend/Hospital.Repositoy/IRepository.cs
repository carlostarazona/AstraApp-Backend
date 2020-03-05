using System.Collections.Generic;

namespace Hospital.Repositoy
{
    public interface IRepository<T>
    {
        bool  Save(T entity);
        bool  Update(T entity);

        bool  Delete(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> Listarid (int id);

        T Get(int id);
        
      
    }
}