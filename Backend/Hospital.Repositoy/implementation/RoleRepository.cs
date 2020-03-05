using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;
using System.Linq;


namespace Hospital.Repositoy.implementation
{
    public class RoleRepository : IRoleRepository
    {
        private ApplicationDbContext context;
        public RoleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
         public bool Delete(int id)
        {
           try
            {
                var result = new Role();
                result = context.Roles.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Role Get(int id)
        {
            var result = new Role();
            try {
                result = context.Roles.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Role> GetAll()
        {
            var result = new List<Role>();
            try{
                result = context.Roles.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Role entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }



        public bool Update(Role entity)
        {
            try{
                var newRole = context.Roles.Single(x => x.Id == entity.Id);
                newRole.Id = entity.Id;
                newRole.namerole = entity.namerole;
                 newRole.descripcion=entity.descripcion;
                 
                context.Update(newRole);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }
            public IEnumerable<Role> Select()
        {
       
             var result = context.Roles.ToList();
            return result.Select(c => new Role
            {
                Id = c.Id,
                namerole= c.namerole,
            });
           
        }

        public IEnumerable<Role> Listarid(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}