using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Repositoy
{
    public interface IScheduleRepository:IRepository<Schedule>
    {
          IEnumerable<Schedule> Select(int id);
    }
}