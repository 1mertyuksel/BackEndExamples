using CompanyInfo.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.Models.Concrete
{
    public class Urun:BaseEntity
    {
        public string UrunAdi { get; set; }
        public string? UrunKodu { get; set; }
        public double? Fiyat { get; set; }

        public double? Adet { get; set; }
        //Birim ile 1-N ilişki tanımlaması
        public int BirimId { get; set; }
        public Birim Birim { get; set; }

        //Kategoriler ile N-N İlişki tanımlaması
        public ICollection<Kategori> Kategoriler { get; set; }
        public ICollection<Tedarikci> Tedarikciler { get; set; }

    }
}
