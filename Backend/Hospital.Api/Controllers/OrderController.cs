using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Astra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
         private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet ("[action]")]
        public ActionResult Get()
        {
            return Ok(
                orderService.GetAll()
            );
        }

         [HttpGet("[action]/{id}")]
        public ActionResult Listarid( int id)
        {
            return Ok(
                orderService.Listarid(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Order order )
        {
            return Ok(
                orderService.Save(order)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Order order)
        {
            return Ok(
               orderService.Update(order)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                orderService.Delete(id)
            );
        }

        [HttpGet("[action]/{id}")]
         public ActionResult Select(int id)
        {
            return Ok( orderService.Select(id));
        }
    }
}