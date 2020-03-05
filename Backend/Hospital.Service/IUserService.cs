using Hospital.Entity;
using System.Collections.Generic;

namespace Hospital.Service
{
    public interface IUserService : IService <User>
    {
          IEnumerable<Hospitaluser> SelectHospital();
          IEnumerable<AreaUser> SelectArea();

          IEnumerable<User> Select();
           string Login(Login model);
    }
}