using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class FinalreportController: ControllerBase
    {
        private IFinalReportService finalreportService;

        public FinalreportController( IFinalReportService finalreportService)
        {
            this.finalreportService = finalreportService;
        }

        [HttpGet ("[action]")]
        public ActionResult Get()
        {
            return Ok(
               finalreportService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Finalreport finalreport)
        {
            return Ok(
              finalreportService.Save(finalreport)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody]Finalreport finalreport)
        {
            return Ok(
                finalreportService.Update(finalreport)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
               finalreportService.Delete(id)
            );
        }

         [HttpGet("[action]/{id}")]
        public ActionResult Listarid( int id)
        {
            return Ok(
                finalreportService.Listarid(id)
            );
        }
    }
}