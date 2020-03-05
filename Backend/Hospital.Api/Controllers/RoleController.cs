using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hospital.Service;
using Hospital.Entity;
namespace Hospital.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService roleService;

        public RoleController (IRoleService roleService)
        {
            this.roleService = roleService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                roleService.GetAll()
            );
        }

       

        // GET: api/Roles/SelectS

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Role  role)
        {
            return Ok(
            roleService.Save(role)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Role  role)
        {
            return Ok(
            roleService.Update(role)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            roleService.Delete(id)
            
            );
        }

        [HttpGet("[action]")]
         public ActionResult Select()
        {
            return Ok( roleService.Select());
        }
    }



}
