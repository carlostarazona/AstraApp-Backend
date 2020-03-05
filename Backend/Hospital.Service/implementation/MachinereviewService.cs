using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class MachinereviewService : IMachinereviewService
    {
         private IMachinereviewRepository machinereviewRepository;
        public MachinereviewService(IMachinereviewRepository machinereviewRepository)
        {
            this.machinereviewRepository=machinereviewRepository;
        }
        public bool Delete(int id)
        {
            return machinereviewRepository.Delete(id);
        }

        public Machinereview Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Machinereview> GetAll()
        {
            return machinereviewRepository.GetAll();
        }

        public IEnumerable<Machinereview> Listarid(int id)
        {
            return machinereviewRepository.Listarid(id);
        }

        public bool Save(Machinereview entity)
        {
            return machinereviewRepository.Save(entity);
        }

        public IEnumerable<Machinereview> Select()
        {
           return machinereviewRepository.Select();
        }

        public bool Update(Machinereview entity)
        {
            return machinereviewRepository.Update(entity);
        }
    }
}