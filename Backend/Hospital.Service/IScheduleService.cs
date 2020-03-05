using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Service
{
    public interface IScheduleService:IService<Schedule>
    {
          IEnumerable<Schedule> Select(int id);
    }
}