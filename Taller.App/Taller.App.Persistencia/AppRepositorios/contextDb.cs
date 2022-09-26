using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.App.Dominio;


namespace Taller.App.Persistencia
{

    public class ContextDb : DbContext

    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasKey(b => b.Id).HasName("PrirmaryKey_Id");

        }
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<JefeOperaciones> JefeOperaciones { get; set; }
        public DbSet<Revision> Revisiones { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog= TallerData");
                //Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = C:\Users\ASUS\\TallerData;

            }
        }
    }
}