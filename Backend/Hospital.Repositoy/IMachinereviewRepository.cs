using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Repositoy
{
    public interface IMachinereviewRepository: IRepository<Machinereview>
    {
         IEnumerable <Machinereview> Select();
    }
}