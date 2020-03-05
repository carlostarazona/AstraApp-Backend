using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hospital.Service;
using Hospital.Entity;
using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hospital.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController (IUserService userService)
        {
            this.userService = userService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult  Get()
        {
            return Ok(
                userService.GetAll()
            );
        }

        // GET api/values/5
  
        // POST api/values
        [HttpPost("[action]")]
        public ActionResult Save(User  user)
        {
            return Ok(
            userService.Save(user)
            );
        }

         [HttpPost("[action]")]

         public ActionResult Login(Login Entity)
         {
             return Ok(
                 userService.Login(Entity)
             );
         }
     
  
         

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] User  user)
        {
            return Ok(
            userService.Update(user)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            userService.Delete(id)
            
            );
        }

          [HttpGet("[action]")]
         public ActionResult SelectHospital()
        {
            return Ok( userService.SelectHospital());
        }

          [HttpGet("[action]")]
         public ActionResult SelectArea()
        {
            return Ok( userService.SelectArea());
        }

         [HttpGet("[action]")]
         public ActionResult Select()
         {
             return Ok(userService.Select());
         }



        

       

      
    }



}
