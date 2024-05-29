using CompanyInfo.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Urun> Urunler  { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Birim> Birimler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=CompanyDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
        }
    }
}
