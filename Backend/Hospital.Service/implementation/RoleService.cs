using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class RoleService : IRoleService
    {
        private IRoleRepository roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
           this.roleRepository = roleRepository;
        }

         public bool Delete(int id)
        {
          return roleRepository.Delete(id);
        }

        public Role Get(int id)
        {
          return roleRepository.Get(id);
        }

        public IEnumerable<Role> GetAll()
        {
         return roleRepository.GetAll();
        }

        public bool Save(Role entity)
        {
          return roleRepository.Save(entity);
        }

        public bool Update(Role entity)
        {
          return roleRepository.Update(entity);
        }

         public IEnumerable<Role> Select()
        {
            return roleRepository.Select();
        }

        public IEnumerable<Role> Listarid(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}