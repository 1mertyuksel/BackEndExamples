using CompanyInfo.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.Models.Concrete
{
    public class Tedarikci:BaseEntity   
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; } 


        public ICollection<Urun> Urunler { get; set; }
    }
}
