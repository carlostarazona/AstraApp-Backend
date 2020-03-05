using Hospital.Entity;
using System.Collections.Generic;

namespace Hospital.Repositoy
{
    public interface IRoleRepository:IRepository<Role>
    {
          IEnumerable<Role> Select();
    }
}