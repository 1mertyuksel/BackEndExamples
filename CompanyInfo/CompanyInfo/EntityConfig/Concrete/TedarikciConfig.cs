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
    public class TedarikciConfig: BaseConfig<Tedarikci>
    {
        public override void Configure(EntityTypeBuilder<Tedarikci> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SirketAdi).HasMaxLength(50);
            builder.Property(p => p.VergiNo).HasMaxLength(20);
            builder.HasIndex(p => p.VergiNo).IsUnique();

            builder.HasData(new Tedarikci { Id = 1, SirketAdi = "Abcd", VergiNo = "1234", DateTime = DateTime.Now },
            new Tedarikci { Id = 2, SirketAdi = "Abc", VergiNo = "123", DateTime = DateTime.Now },
            new Tedarikci { Id = 3, SirketAdi = "Bca", VergiNo = "321", DateTime = DateTime.Now },
            new Tedarikci { Id = 4, SirketAdi = "Cba", VergiNo = "213", DateTime = DateTime.Now }
            );

        }
    }
}
