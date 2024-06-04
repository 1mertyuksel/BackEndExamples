using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using CompanyInfo.MVCUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class UrunController :Controller
    {
        private readonly IUrunManager urunManager;

        private readonly IBirimManager BirimManager;

        public UrunController(IUrunManager urunManager,IBirimManager birimManager)
        {
            this.urunManager = urunManager;
            BirimManager = birimManager;
        }

        public IActionResult Index()
        {
            var urunler = urunManager.GetAll();
            return View(urunler);
           
        }
       
        public IActionResult Create()
        {
            //Kendi Yazdigimiz validation'larin oldugu Class'tan 
            //Instance aliyoruz ve bunu view'e gonderiyoruz
            UrunInsertVM insertVM = new UrunInsertVM();
            ViewBag.birimler = BirimManager.GetAll();
            return View(insertVM);
        }
        // Olusturulan form'un bizim tarafimizdan olusturuldugunu garanti eder

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(UrunInsertVM insertVM)
        {
            //Gelen Model dogru gelmişmi ? 
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Birşeyler yanliş gitti");
                ViewBag.birimler = BirimManager.GetAll();
                return View();
            }
            else
            {
                //Amele yontemi ile
                Urun yeniUrun = new Urun()
                {
                    UrunKodu = insertVM.UrunKodu,
                    UrunAdi = insertVM.UrunAdi,
                    BirimId= insertVM.BirimId,
                    Adet=insertVM.Adet,
                    Fiyat   =insertVM.Fiyat
                };
                var sonuc = urunManager.Insert(yeniUrun);
                if (sonuc > 0)
                    return RedirectToAction("Index");
                else 
                {
                   
                    ModelState.AddModelError("", "Beklenmedik bir hata olustu. Lütfen daha sonra tekrar deneyiniz");
                    return View();
                }

            }
           
        }
    }
}
