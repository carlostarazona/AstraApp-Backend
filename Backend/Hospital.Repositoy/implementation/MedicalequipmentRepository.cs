using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositoy.implementation
{
    public class MedicalequipmentRepository : IMedicalequipmentRepository
    {

         private ApplicationDbContext context;

        public MedicalequipmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Medicalequipment Get(int id)
        {
            throw new System.NotImplementedException();
        }

         public IEnumerable<Medicalequipment> Listarid(int id)
        {
            
            try
            {
              var result = context.Medicalequipments.Where(x => x.Iduser == id);
              return result;
            }

            catch (System.Exception)
            {

               return null;
            }
        
         
        }

        public IEnumerable<Medicalequipment> GetAll()
        {
        var result = new List<Medicalequipment>();
            try
            {
                result = context.Medicalequipments.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
         
        }

        public bool Save(Medicalequipment entity)
        {
             try
            {
                var newuser = context.Users.Single(x=> x.Id == entity.Iduser);
                entity.Nameuser = newuser.Name;
                entity.Namehospital = newuser.Namehospital;
                entity.Namearea = newuser.Namearea;
                entity.User = newuser;
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Medicalequipment entity)
        {
            try
            {
                 var medicalequipmentOrigina = context.Medicalequipments.Single(
                     x => x.Id == entity.Id
                 );
                 var newuser = context.Users.Single(x=> x.Id == entity.Iduser);
                
                medicalequipmentOrigina.Id=entity.Id;
               medicalequipmentOrigina.Statedescription = entity.Statedescription;
                medicalequipmentOrigina.Brand = entity.Brand;
                medicalequipmentOrigina.Name = entity.Name;
                medicalequipmentOrigina.Nameuser = newuser.Name;
                medicalequipmentOrigina.Namehospital = newuser.Namehospital;
                medicalequipmentOrigina.Namearea = newuser.Namearea;
                medicalequipmentOrigina.User = newuser;
                 context.Update(medicalequipmentOrigina);
                 context.SaveChanges();
                  }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }


    public IEnumerable<Medicalequipment> Select(int id)
        {
       
             var result = Listarid(id);
            return result.Select(c => new Medicalequipment
            {
                Id = c.Id,
                Name= c.Name,
            });
           
        }

        
    }


    
}