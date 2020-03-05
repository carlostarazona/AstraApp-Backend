using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Service
{
    public interface IMachinereviewService:IService<Machinereview>
    {
          IEnumerable <Machinereview> Select();
    }
}