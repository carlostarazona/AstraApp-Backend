namespace Hospital.Entity
{
    public class Machinereview
    {
        public int Id{get;set;}
        public string Reviewdate {get;set;}

        public string description{get;set;}
        public int Idschedule{get;set;}

        public string Nombremaquina{get;set;}
        public Schedule Schedule{get;set;}

        
    }
}