using CompanyInfo.EntityConfig.Abstract;
using CompanyInfo.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyInfo.EntityConfig.Concrete
{
    public  class KategoriConfig:BaseConfig<Kategori>
    {
        public override void  Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.HasIndex(p=>p.KategoriAdi).IsUnique();
            builder.HasData(new Kategori { Id = 1, KategoriAdi = "Gıda", DateTime = DateTime.Now },
            new Kategori { Id = 2, KategoriAdi = "Tekstil", DateTime = DateTime.Now }


            );
        }   
    }
}
