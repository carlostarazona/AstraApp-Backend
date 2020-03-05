using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Repositoy
{
    public interface IOrderRepository : IRepository<Order>
    {
          IEnumerable<Order> Select(int id);
          
    } 
}