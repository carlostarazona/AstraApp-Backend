using Hospital.Entity;
using System.Collections.Generic;

namespace Hospital.Service
{
    public interface IRoleService : IService<Role>
    {
           IEnumerable<Role> Select();
    }
}