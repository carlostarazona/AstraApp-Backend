using System.Collections.Generic;
using Hospital.Entity;

namespace Hospital.Service
{
    public interface IMedicalequipmentService:IService<Medicalequipment>
    {
           IEnumerable<Medicalequipment> Select(int id);
    }
}