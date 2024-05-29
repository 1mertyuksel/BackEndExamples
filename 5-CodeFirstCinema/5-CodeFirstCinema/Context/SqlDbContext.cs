using _5_CodeFirstCinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CodeFirstCinema.Contexts
{
    public class SqlDbContext : DbContext
    {

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seans { get; set; }
        public DbSet<Yonetmen> Yonetmen { get; set; }

        public DbSet<Gosterim> Gosterim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024Cinema;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Salon Entity Ayarlari
            modelBuilder.Entity<Salon>()
                   .HasKey(p => p.Id);
            modelBuilder.Entity<Salon>()
                .Property(p => p.SalonAdi)
                .HasMaxLength(50);

            modelBuilder.Entity<Salon>().HasIndex(p => p.SalonAdi).IsUnique();
            #endregion
            #region Seans Entity Ayarlari

            #endregion

        }
    }
}