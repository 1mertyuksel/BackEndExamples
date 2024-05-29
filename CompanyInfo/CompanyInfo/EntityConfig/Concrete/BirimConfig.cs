using CompanyInfo.EntityConfig.Abstract;
using CompanyInfo.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.EntityConfig.Concrete
{
    public class BirimConfig:BaseConfig<Birim>
    {
        public override void Configure(EntityTypeBuilder<Birim> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.BirimAdi).HasMaxLength(50);
            builder.HasIndex(p=>p.BirimAdi).IsUnique();
            builder.HasData(new Birim { Id=1 , BirimAdi="Adet",DateTime=DateTime.Now },
            new Birim {  Id=2 ,BirimAdi="Cm",DateTime=DateTime.Now},
            new Birim { Id=3, BirimAdi="Gram",DateTime=DateTime.Now},
            new Birim { Id=4, BirimAdi= "Miligram", DateTime=DateTime.Now}
              );
        }
    }
}
