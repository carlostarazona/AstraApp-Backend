

using System.Collections.Generic;
using System.Threading.Tasks;
using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MedicalequipmentController: ControllerBase
    {
         private IMedicalequipmentService medicalequipmentService;

        public MedicalequipmentController(IMedicalequipmentService medicalequipmentService)
        {
            this.medicalequipmentService = medicalequipmentService;
        }

 

        [HttpPost]
        public ActionResult Post([FromBody]Medicalequipment medicalequipment)
        {
            return Ok(
                medicalequipmentService.Save(medicalequipment)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody]Medicalequipment medicalequipment)
        {
            return Ok(
                medicalequipmentService.Update(medicalequipment)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                medicalequipmentService.Delete(id)
            );
        }

        [HttpGet("{id}")]
        public ActionResult Listarid(int id)
        {
            return Ok(
                medicalequipmentService.Listarid(id)
            );
        }
        
        [HttpGet("[action]")]
        public ActionResult GetAll()
        {
            return Ok(medicalequipmentService.GetAll());
        }

         [HttpGet("[action]/{id}")]
         public ActionResult Select(int id)
        {
            return Ok( medicalequipmentService.Select(id));
        }
    }
}