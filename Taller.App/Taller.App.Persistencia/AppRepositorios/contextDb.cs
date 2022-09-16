using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.App.Dominio;


namespace Taller.App.Persistencia
{
    public class contextDb : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Mecanico> Mecanico { get; set; }
        public DbSet<Propietario> Propietario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= TallerAppData");
            }

        }
    }

}