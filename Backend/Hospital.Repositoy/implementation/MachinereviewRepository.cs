using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class MachinereviewRepository : IMachinereviewRepository
    {

         private ApplicationDbContext context;

        public  MachinereviewRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
             try
            {
                var machineOrigina = context.Machinereviews.Single(
                     x => x.Id == id);
                context.Remove(machineOrigina);
                context.SaveChanges();
                
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public Machinereview Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Machinereview> GetAll()
        {
           var result = new List<Machinereview>();
            try
            {
                result = context.Machinereviews.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Machinereview entity)
        {
             try
            {
                 var newschedule = context.Schedules.Single(
                     x => x.Id == entity.Idschedule
                 );
                 entity.Nombremaquina = newschedule.Nombremedicalequipment;
                 entity.Schedule = newschedule;
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Machinereview entity)
        {
             try
            {
                 var machinereviewOrigina = context.Machinereviews.Single(
                     x => x.Id == entity.Id
                 );
                  var newschedule = context.Schedules.Single(
                     x => x.Id == entity.Idschedule
                 );

                 machinereviewOrigina.Id=entity.Id;
                 machinereviewOrigina.Reviewdate = entity.Reviewdate;
                machinereviewOrigina.description = entity.description;
                 machinereviewOrigina.Nombremaquina = newschedule.Nombremedicalequipment;
                 machinereviewOrigina.Schedule = newschedule;
           

                 context.Update(machinereviewOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

            public IEnumerable<Machinereview> Select()
             {

                 var result = context.Machinereviews.ToList();
                 return result.Select(x=> new Machinereview{
                     Id = x.Id,
                     Nombremaquina = x.Nombremaquina,

                 });
        }

        public IEnumerable<Machinereview> Listarid(int id)
        {
            var result = new List<Machinereview>();
            var newuser = context.Users.Single(x=> x.Id == id);

            try
            {
                if(newuser.Namerol == "Doctor")
                {
                     result = context.Machinereviews.Where(x=> x.Schedule.Order.Medicalequipment.Iduser == id).ToList();
                }
                else
                {
                    result = context.Machinereviews.Where(x =>x.Schedule.Iduser == id).ToList();
                }
               
            }
            catch(System.Exception)
            {
                return null;
            }
             return result;
        }
    }
}