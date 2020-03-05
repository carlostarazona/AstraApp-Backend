using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class FinalreportService : IFinalReportService
    {
         private IFinalreportRepository finalreportRepository;
        public  FinalreportService(IFinalreportRepository finalreportRepository)
        {
            this.finalreportRepository=finalreportRepository;
        }
        public bool Delete(int id)
        {
           return finalreportRepository.Delete(id);
        }

        public Finalreport Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Finalreport> GetAll()
        {
            return finalreportRepository.GetAll();
        }

        public IEnumerable<Finalreport> Listarid(int id)
        {
          return finalreportRepository.Listarid(id);
        }

        public bool Save(Finalreport entity)
        {
            return finalreportRepository.Save(entity);
        }

        public bool Update(Finalreport entity)
        {
           return finalreportRepository.Update(entity);
        }
    }
}