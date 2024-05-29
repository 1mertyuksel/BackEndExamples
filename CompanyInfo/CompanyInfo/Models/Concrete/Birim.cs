using CompanyInfo.Models.Abstract;

namespace CompanyInfo.Models.Concrete
{
    public class Birim:BaseEntity
    {
        public string BirimAdi { get; set; }
        public ICollection<Urun> Urunler { get; set; }

    }
}