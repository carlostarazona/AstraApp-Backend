using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Repositoy
{
    public interface  IMedicalequipmentRepository : IRepository<Medicalequipment>
   {
               IEnumerable<Medicalequipment> Select(int id);
               
   }
}