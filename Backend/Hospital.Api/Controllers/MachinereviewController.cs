using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinereviewController: ControllerBase
    {
         private IMachinereviewService machieneviewService;

        public MachinereviewController(IMachinereviewService machieneviewService)
        {
            this.machieneviewService = machieneviewService;
        }

         [HttpGet("[action]")]
        public ActionResult Get()
        {
            return Ok(
               machieneviewService.GetAll()
            );
        }

         [HttpGet("[action]/{id}")]
        public ActionResult Listarid( int id)
        {
            return Ok(
                machieneviewService.Listarid(id)
            );
        }

          [HttpGet("[action]")]
         public ActionResult Select()
         {
             return Ok(machieneviewService.Select());
         }

        [HttpPost]
        public ActionResult Post([FromBody] Machinereview machinereview)
        {
            return Ok(
               machieneviewService.Save(machinereview)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody]Machinereview machinereview)
        {
            return Ok(
                machieneviewService.Update(machinereview)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                machieneviewService.Delete(id)
            );
        }
    }
}