using CompanyInfo.BL.Managers.Concrete;
using CompanyInfo.DAL.Repository.Abstract;
using CompanyInfo.DAL.Repository.Concrete;
using CompanyInfo.Entities.DbContexts;
using CompanyInfo.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;

namespace CompanyInfo.ConsoleApp
{
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
            //var birim = appDb.Birimler.FirstOrDefault(p => p.BirimAdi.Contains("Adet"));
            //var asus = new Urun
            //{
            //    Birim = birim,
            //    Adet = 1,
            //    Fiyat = 1000,
            //    UrunAdi = "Asus Vivobook 15",
            //    UrunKodu = "E1504FA-NJ993",
            // };
            //appDb.Urunler.Add(asus);
            //var bilgisayar = appDb.Kategoriler.Include(p=>p.Urunler).FirstOrDefault(p => p.KategoriAdi == "Bilgisayar");
            //bilgisayar.Urunler.Add(asus);
            //var notebook = appDb.Kategoriler.Include(p => p.Urunler).FirstOrDefault(p => p.KategoriAdi == "Notebook");
            //notebook.Urunler.Add(asus);

            //var elektronik = new Kategori { KategoriAdi = "Elektronik" };
            //elektronik.Urunler = new List<Urun>();
            //elektronik.Urunler.Add(asus);
            //appDb.Kategoriler.Add(elektronik);


            //appDb.SaveChanges();
            #endregion
            #region Asus notebook icin Notebook kategorisi yerine Laptop kategorisini koyalim
            //var asus = appDb.Urunler
            //    .Include(p=>p.Kategoriler)
            //    .FirstOrDefault(p=>p.Id==4);
            
            //var silinecekKategori = asus.Kategoriler.FirstOrDefault(p => p.KategoriAdi.ToUpper() =="noTebooK".ToUpper());

            //var eklenecekKategori = appDb.Kategoriler.FirstOrDefault(p => p.KategoriAdi.Contains("laptop"));


            //asus.Kategoriler.Remove(silinecekKategori);
            //asus.Kategoriler.Add(eklenecekKategori);

            //appDb.SaveChanges();

            #endregion

            #region Repository'leri Kullanma
            //BirimRepository birimRepository = new BirimRepository();

            //IRepository<Birim> brepos = new BirimRepository();
            //var birimrepo = new Repository<Birim>();
            //var result1 = birimrepo.GetAll();
            //var result2 = brepos.GetAll();
            //var birimler = birimRepository.GetAll();
            //birimler.ForEach(p => Console.WriteLine(p.BirimAdi));
            #endregion

            #region Manager Sisinflarini Kullanma
            var birimManager =new  ManagerBase<Birim>();
            var birimler = birimManager.GetAll();

            var urunManager = new UrunManager();

            var kategoriManager = new ManagerBase<Kategori>();

            //var buzdolabi = new Urun
            //{
            //    BirimId=1,
            //    Fiyat=20000,
            //    UrunAdi="Arcelik Buzdolabi",
            //    Adet = 2
            //};

            var kalem = new Urun
            {
                UrunAdi = "Kursun Kalem",
                UrunKodu = "AAABBCC",
                Fiyat =null,
                Adet=2

            };
            try
            {
                urunManager.Insert(kalem);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           // var kategoriManager= new ManagerBase<Kategori>();

           // var elektornik = kategoriManager.Get(p => p.KategoriAdi == "Elektronik");
           // var beyazesya = new Kategori { KategoriAdi = "BeyazEsya", Aciklama = "Beyaz Esya" };

           //// buzdolabi.Kategoriler.Add(elektornik);
           // buzdolabi.Kategoriler.Add(beyazesya);
           // urunManager.Insert(buzdolabi);

            var liste = urunManager.KritikStokSeviyesiAltindakiler();

            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
