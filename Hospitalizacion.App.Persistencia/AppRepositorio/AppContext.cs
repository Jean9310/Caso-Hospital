using Microsoft.EntityFrameworkCore;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public class AppContext: DbContext
    {
       
        public DbSet<Auxiliar> Auxiliar {get; set; }
        public DbSet<Enfermero> Enfermero {get; set;}
        public DbSet<Familiar> Familiar {get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica {get; set; }
        public DbSet<Medico> Medico {get; set; }
        public DbSet<PacienteFamiliar> PacienteFamiliar {get; set; }
        public DbSet<Paciente> Paciente {get; set; }
       public DbSet<SignosVitales> SignosVitales {get; set; }
        
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= HospitalizacionData");
            }
        }


    }
}