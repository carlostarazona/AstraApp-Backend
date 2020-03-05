namespace Hospital.Entity
{
    public class Finalreport
    {
        public int Id{get;set;}
        public string Description{get;set;}
        public string Reportdate {get;set;}
        public int Idmachinereview{get;set;}
         public string Nombremaquina{get;set;}
        public Machinereview Machinereview{get;set;}
    }
}