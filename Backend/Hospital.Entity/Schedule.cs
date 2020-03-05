namespace Hospital.Entity
{
    public class Schedule
    {
        public int Id{get;set;}

        public string Name{get;set;}

        public string Agreeddate{get;set;}
        public string arrivaldate{get;set;}


        public int Idorder{get;set;}
        public int Iduser{get;set;}


         public string Descriptionorder {get;set;}
          public string Nombremedicalequipment{get;set;}
         public string Hospitaluser{get;set;}


         public Order Order{get;set;}
         public User User{get;set;}
    }
}