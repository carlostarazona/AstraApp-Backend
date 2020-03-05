using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Entity
{
    public class Medicalequipment
    {
        public int Id { get; set; }

         public int Iduser { get; set; }
         public string Nameuser{get;set;}
         public string Namehospital{get;set;}
         public string Namearea{get;set;}

        public string Statedescription { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }

        public User User{get;set;}
    }
}