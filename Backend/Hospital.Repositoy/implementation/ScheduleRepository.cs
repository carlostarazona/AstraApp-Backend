using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    
    public class ScheduleRepository : IScheduleRepository
    {

        private ApplicationDbContext context;

        public ScheduleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }        
        public bool Delete(int id)
        {
            try{
            var newschedule = context.Schedules.Single(x => x.Id == id);
            context.Remove(newschedule);
            context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public Schedule Get(int id)
        {
            var result = new Schedule();
            try {
                result = context.Schedules.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Schedule> GetAll()
        {
            var result = new List<Schedule>();
            try
            {
                result = context.Schedules.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Schedule entity)
        {
            try
            {
                var neworder = context.Orders.Single(x=>x.Id == entity.Idorder);
                var newuser = context.Users.Single(x=>x.Id == entity.Iduser);
                entity.Nombremedicalequipment = neworder.Nombremedicalequipment;
                entity.Descriptionorder = neworder.Description;
                entity.Hospitaluser = newuser.Namehospital;
                entity.User =newuser;
                entity.Order = neworder;

                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Schedule entity)
        {
            try
            {
                 var scheduleOrigina = context.Schedules.Single(
                     x => x.Id == entity.Id
                 );

                var neworder = context.Orders.Single(x=>x.Id == entity.Idorder);
                var newuser = context.Users.Single(x=>x.Id == entity.Iduser);

                scheduleOrigina.Nombremedicalequipment = neworder.Nombremedicalequipment;
                scheduleOrigina.Descriptionorder = neworder.Description;
                scheduleOrigina.Hospitaluser = newuser.Namehospital;
                scheduleOrigina.Id=entity.Id;
                scheduleOrigina.Name=entity.Name;
                scheduleOrigina.Agreeddate= entity.Agreeddate;
                scheduleOrigina.arrivaldate = entity.arrivaldate;
                scheduleOrigina.Idorder = entity.Idorder;
                scheduleOrigina.Iduser = entity.Iduser;
                scheduleOrigina.User = newuser;
                scheduleOrigina.Order = neworder;

                 context.Update(scheduleOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
            public IEnumerable<Schedule> Select(int id)
             {
                 var result = ListarSchedule(id);
                 return result.Select(x => new Schedule{
                     Id = x.Id,
                     Name = x.Name,
                 });
            }

        public IEnumerable<Schedule> Listarid(int id)
        {
             var result = new List<Schedule>();
             var newuser = context.Users.Single(x => x.Id == id);
            try
            {
                if(newuser.Namerol == "Doctor")
                {
                result = context.Schedules.Where(x=> x.Order.Medicalequipment.Iduser == id).ToList();
                }
                else
                {
                result = context.Schedules.Where(x=> x.Iduser == id).ToList();
                }
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }


           private IEnumerable<Schedule> ListarSchedule(int id)
        {
             var result = new List<Schedule>();
             var newuser = context.Users.Single(x => x.Id == id);
            try
            {
                if(newuser.Namerol == "Engineer")
                {
               result = context.Schedules.Where(x=> x.Iduser == id).ToList();
                }
                else
                {
               return null;
                }
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }
    }
}