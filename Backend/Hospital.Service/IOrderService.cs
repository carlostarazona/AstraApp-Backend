using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Service
{
    public interface IOrderService:IService<Order>
    {
         IEnumerable<Order> Select(int id);
    }
}