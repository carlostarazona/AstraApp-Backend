using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Hospital.Entity;

using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Hospital.Repositoy.implementation
{
    public class UserRepository : IUserRepository
    {
         private ApplicationDbContext context;
         private readonly IConfiguration config;
        public UserRepository(ApplicationDbContext context , IConfiguration config)
        {
            this.context = context;
            this.config = config;
        }
         public bool Delete(int idd)
        {
             try
            {
                var userOrigina = context.Users.Single(
                     x => x.Id == idd);
                context.Remove(userOrigina);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public User Get(int id)
        {
             var result = new User();
            try {
                result = context.Users.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<User> GetAll()
        {
           var result = new List<User>();
            try{
                result = context.Users.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(User entity)
        {
        
            try
            {
              var correo = entity.Email.ToLower();
              var user = context.Users.Where(x => x.Email == correo).FirstOrDefault();
              if (user == null) 
               {  

                Crear_Password_Hash(entity.password, out byte[] password_hashh, out byte[] password_salth);

                var newrol = context.Roles.Single(x =>x.Id == entity.Idrol);
                var newhospital = context.Hospitalusers.Single(x =>x.Id == entity.Idhospital);
                var newArea = context.AreaUsers.Single(x =>x.Id == entity.Idarea);
                entity.Hospital = newhospital;
                entity.Role = newrol;
                entity.Area = newArea;
                entity.Namerol = newrol.namerole;
                entity.Namehospital = newhospital.Namehospital;
                entity.Namearea = newArea.Namearea;
                entity.Email = correo;
                entity.password_hash = password_hashh;
                entity.password_salt = password_salth;
                context.Add(entity);
                context.SaveChanges();
               }
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        private void Crear_Password_Hash(string password, out byte[] password_hash, out byte[] password_salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //Llave
                password_salt = hmac.Key;
                //Password
                password_hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); 
            }
        }

        public bool Update(User entity)

        {
            try{
                var newUser = context.Users.Single(x => x.Id == entity.Id);
                var newrol = context.Roles.Single(x =>x.Id == entity.Idrol);
                var newhospital = context.Hospitalusers.Single(x =>x.Id == entity.Idhospital);
                var newArea = context.AreaUsers.Single(x =>x.Id == entity.Idarea);
                
                newUser.Hospital = newhospital;
                newUser.Area = newArea;
                newUser.Role = newrol;
                newUser.Id = entity.Id;
                newUser.Idrol= entity.Idrol;
                newUser.Idarea= entity.Idarea;
                newUser.Idhospital= entity.Idhospital;
                newUser.Namerol =newrol.namerole;
                newUser.Namehospital = newhospital.Namehospital;
                newUser.Namearea = newArea.Namearea;
                newUser.Typedoc = entity.Typedoc;
                newUser.Numdoc = entity.Numdoc;
                newUser.Name = entity.Name;
                newUser.Email=entity.Email.ToLower();
                newUser.Phone = entity.Phone;

                
            if (entity.act_password == true)
            {
                Crear_Password_Hash(entity.password, out byte[] password_Hash, out byte[] password_Salt);
                newUser.password_hash = password_Hash;
                newUser.password_salt = password_Salt;
            }

                context.Update(newUser);
                 context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }

      
            public IEnumerable<Hospitaluser> SelectHospital()
        {
       
             var result = context.Hospitalusers.ToList();
            return result.Select(c => new Hospitaluser
            {
                Id = c.Id,
                Namehospital= c.Namehospital
            });
           
        }
          public IEnumerable<AreaUser> SelectArea()
        {
       
             var result = context.AreaUsers.ToList();
            return result.Select(c => new AreaUser
            {
                Id = c.Id,
                Namearea= c.Namearea,
            });
           
        }

        public IEnumerable<User> Select()
        {
            var result = context.Users.Where(x => x.Namerol == "Engineer").ToList();
            return result.Select(c => new User{
                Id = c.Id,
                Name = c.Name,
            });
        }
      
      public string Login(Login model)
        {
            var correo = model.email.ToLower();
            var newUser = context.Users.FirstOrDefault(x => x.Email == correo);
            if (newUser == null)
            {
             return "404";
            }
            //verificamos password
            if (!VerificarPassword(model.password, newUser.password_hash, newUser.password_salt))
            {
                    return "404";
            }
            var claims = new List<Claim>
            {
                //Para netcore
                new Claim(ClaimTypes.NameIdentifier, newUser.Id.ToString()),
                new Claim(ClaimTypes.Email,correo),
                new Claim(ClaimTypes.Role, newUser.Namerol),
                //Para vuetify
                new Claim("Id", newUser.Id.ToString()),
                new Claim("rol", newUser.Namerol),
                new Claim("nombre", newUser.Name),
            };
            var  token = GenerarToken(claims);
            return token;
        }
        private string GenerarToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
              config["Jwt:Issuer"],
              config["Jwt:Issuer"],
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: creds,
              claims: claims);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        

        private bool VerificarPassword(string password, byte[] passwordHash_almacenado, byte[] passwordSalt )
        {
            //Vamos a encriptar el password usando la llave passwordSalt y si el resultado es igual al password Hash entonces el password es correcto
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) {
                var passwordHashNuevo = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                //Con esto comparamos la secuencia de bytes, devolvera true si son iguales
                return new ReadOnlySpan<byte>(passwordHash_almacenado).SequenceEqual(new ReadOnlySpan<byte>(passwordHashNuevo));
            }
        }

        public IEnumerable<User> Listarid(int id)
        {
            throw new NotImplementedException();
        }
    }
}