
namespace Hospital.Entity
{
    public class User
    {
        public int Id { get; set; }        
        public string Name { get; set; }


        public string Namehospital { get; set; }
         public string Namearea { get; set; }
         public string Namerol { get; set; }


         public int Idrol { get; set; }
         public int Idarea { get; set; }
         public int Idhospital { get; set; }


        public string Typedoc { get; set; }
        public string Numdoc { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }   
        public string password { get; set; }
        public bool act_password { get; set; }
        public byte[] password_hash { get; set; }
        public byte[] password_salt { get; set; }



        public Role Role{get;set;}
        public AreaUser Area{get;set;}
        public Hospitaluser Hospital{get;set;}
      
    }
}