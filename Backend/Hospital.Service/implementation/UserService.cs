using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;
namespace Hospital.Service.implementation
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
         public bool Delete(int id)
        {
            return userRepository.Delete(id);
        }

        public User Get(int id)
        {
           return userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
          return userRepository.GetAll();
        }

        public bool Save(User entity)
        {
           return userRepository.Save(entity);
        }

        public bool Update(User entity)
        {
           return userRepository.Update(entity);
        }

          public IEnumerable<Hospitaluser> SelectHospital()
        {
           return userRepository.SelectHospital();

        }
          public IEnumerable<AreaUser> SelectArea()
        {
            return userRepository.SelectArea();
           
        }
        public IEnumerable<User> Select()
        {
          return userRepository.Select();
        }

       public string Login(Login model)
       {
         return userRepository.Login(model);
       }

        public IEnumerable<User> Listarid(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}