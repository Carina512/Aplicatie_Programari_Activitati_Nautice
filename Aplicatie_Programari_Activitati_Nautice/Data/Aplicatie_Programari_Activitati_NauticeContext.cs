using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicatie_Programari_Activitati_Nautice.models;

namespace Aplicatie_Programari_Activitati_Nautice.Data
{
    public class Aplicatie_Programari_Activitati_NauticeContext : DbContext
    {
        public Aplicatie_Programari_Activitati_NauticeContext (DbContextOptions<Aplicatie_Programari_Activitati_NauticeContext> options)
            : base(options)
        {
        }

        public DbSet<Aplicatie_Programari_Activitati_Nautice.models.Activitate> Activitate { get; set; } = default!;

        public DbSet<Aplicatie_Programari_Activitati_Nautice.models.Programare>? Programare { get; set; }

        public DbSet<Aplicatie_Programari_Activitati_Nautice.models.Review>? Review { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurare pentru tabela Activitate
            modelBuilder.Entity<Activitate>()
                .Property(a => a.Pret)
                .HasColumnType("decimal(18,2)");

            
        }


    }
}
