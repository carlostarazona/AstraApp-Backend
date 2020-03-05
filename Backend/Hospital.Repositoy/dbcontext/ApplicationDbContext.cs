using Hospital.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositoy.dbcontext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Medicalequipment> Medicalequipments { get; set; }
        public DbSet<Finalreport> Finalreports { get; set; }
        public DbSet<Machinereview> Machinereviews { get; set; }
        public DbSet<Hospitaluser> Hospitalusers { get; set; }
        public DbSet<AreaUser> AreaUsers{ get; set; }

        //public DbSet<Consulta> Consultas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>()
                    .Property(p => p.Nombres)
                    .HasColumnName("Nombres")
                    .HasMaxLength(50)
                    .IsRequired();

            
                    
        }
    }
}