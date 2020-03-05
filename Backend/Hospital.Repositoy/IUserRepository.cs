using Hospital.Entity;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hospital.Repositoy
{
    public interface IUserRepository:IRepository<User>
    {
          IEnumerable<Hospitaluser> SelectHospital();
          IEnumerable<AreaUser> SelectArea();
          IEnumerable<User> Select();
          string Login(Login model);
          
    }
}