using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;


namespace Hospital.Service.implementation
{
    public class MedicalequipmentService : IMedicalequipmentService
    {

          private IMedicalequipmentRepository medicalequipmentRepository;
        public MedicalequipmentService(IMedicalequipmentRepository medicalequipmentRepository)
        {
           this.medicalequipmentRepository = medicalequipmentRepository;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Medicalequipment Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Medicalequipment> Listarid (int id)
        {
            return medicalequipmentRepository.Listarid(id);
        }
        public IEnumerable<Medicalequipment> GetAll()
        {
            return medicalequipmentRepository.GetAll();
        }

        public bool Save(Medicalequipment entity)
        {
            return medicalequipmentRepository.Save(entity);
        }

        public bool Update(Medicalequipment entity)
        {
           return medicalequipmentRepository.Update(entity);
        }

        public IEnumerable<Medicalequipment> Select(int id)
        {
            return medicalequipmentRepository.Select(id);
        }
    }
}