using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
           this.scheduleRepository = scheduleRepository;
        }
        public bool Delete(int id)
        {
            return scheduleRepository.Delete(id);
        }

        public Schedule Get(int id)
        {
            return scheduleRepository.Get(id);
        }

        public IEnumerable<Schedule> GetAll()
        {
           return scheduleRepository.GetAll();
        }

        public bool Save(Schedule entity)
        {
            return scheduleRepository.Save(entity);
        }

        public bool Update(Schedule entity)
        {
            return scheduleRepository.Update(entity);
        }

        public  IEnumerable<Schedule> Select(int id)
        {
            return scheduleRepository.Select(id);
        }

        public IEnumerable<Schedule> Listarid(int id)
        {
            return scheduleRepository.Listarid(id);
        }
    }
}