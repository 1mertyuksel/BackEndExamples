using CompanyInfo.DbContexts;
using CompanyInfo.Models.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CompanyInfo.ConsoleApp.DbContext;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext appDb = new AppDbContext();

        //Bilgisayar , NoteBook,BeyazEsya Kategorilere Eklenecek 
        // Asus Notebook Eklenecek
        #region 1. Yol 
        // Once Asus Notebook Tanimlanir
        // Once birim tablosundan adet secilir

        //var birim = appDb.Birimler.FirstOrDefault(p => p.BirimAdi.Contains("Adet"));
        //var bilgisayar = appDb.Kategoriler.FirstOrDefault(p => p.KategoriAdi == "Bilgisayar");
        //var notebook = appDb.Kategoriler.FirstOrDefault(p => p.KategoriAdi == "Notebook");

        //var asus = new Urun
        //{
        //    Birim = birim,
        //    Adet = 1,
        //    Fiyat = 1000,
        //    UrunAdi = "Asus Vivobook 15",
        //    UrunKodu = "E1504FA-NJ993",
        //    Kategoriler = new List<Kategori> 
        //    { 
        //        bilgisayar,
        //        notebook,
        //        new Kategori{ KategoriAdi="Elektronik"}
        //    }
        //};
        //appDb.Urunler.Add(asus);
        //appDb.SaveChanges();
        #endregion
        #region 2. Yol
        var birim = appDb.Birimler.FirstOrDefault(p => p.BirimAdi.Contains("Adet"));
        var asus = new Urun
        {
            Birim = birim,
            Adet = 1,
            Fiyat = 1000,
            UrunAdi = "Asus Vivobook 15",
            UrunKodu = "E1504FA-NJ993",
        };
        appDb.Urunler.Add(asus);
        var bilgisayar = appDb.Kategoriler.Include(p => p.Urunler).FirstOrDefault(p => p.KategoriAdi == "Bilgisayar");
        bilgisayar.Urunler.Add(asus);
        var notebook = appDb.Kategoriler.Include(p => p.Urunler).FirstOrDefault(p => p.KategoriAdi == "Notebook");
        notebook.Urunler.Add(asus);

        var elektronik = new Kategori { KategoriAdi = "Elektronik" };
        elektronik.Urunler = new List<Urun>();
        elektronik.Urunler.Add(asus);
        appDb.Kategoriler.Add(elektronik);


        appDb.SaveChanges();
        #endregion

        Console.WriteLine("Hello, World!");
    }
}
