using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class FinalreportRepository : IFinalreportRepository
    {
           private ApplicationDbContext context;

        public FinalreportRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
               try
            {
                var FinalreportOrigina = context.Finalreports.Single(
                     x => x.Id == id);
                context.Remove(FinalreportOrigina);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public Finalreport Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Finalreport> GetAll()
        {
           var result = new List<Finalreport>();
            try
            {
                result = context.Finalreports.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Finalreport> Listarid(int id)
        {
            var arreglo = new List<Finalreport>();
            try
            {
                arreglo = context.Finalreports.Where(x=> x.Machinereview.Schedule.Order.Medicalequipment.Iduser == id).ToList();

            }
            catch(System.Exception)
            {
                return null;
            }
            return arreglo;
        }

        public bool Save(Finalreport entity)
        {
             try
            {
                 var machineOrigina = context.Machinereviews.Single(
                     x => x.Id == entity.Idmachinereview
                 );
                entity.Nombremaquina = machineOrigina.Nombremaquina;
                entity.Machinereview = machineOrigina;
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Finalreport entity)
        {
            try
            {
                 var finalreportOrigina = context.Finalreports.Single(
                     x => x.Id == entity.Id
                 );
                    var machineOrigina = context.Machinereviews.Single(
                     x => x.Id == entity.Idmachinereview
                 );

                 finalreportOrigina.Id=entity.Id;
                 finalreportOrigina.Description=entity.Description;
                 finalreportOrigina.Reportdate =entity.Reportdate;
                 finalreportOrigina.Nombremaquina=machineOrigina.Nombremaquina;
                 finalreportOrigina.Idmachinereview=entity.Idmachinereview;
                 finalreportOrigina.Machinereview = machineOrigina;
                

                 context.Update(finalreportOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

    }
}