using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.BL.Managers.Concrete;
using CompanyInfo.Entities.Models.Concrete;
using CompanyInfo.MVCUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriManager kategoriManager;

        private readonly IKategoriManager KategoriManager;

        public KategoriController(IKategoriManager kategoriManager)
        {
            this.kategoriManager = kategoriManager;
            KategoriManager = kategoriManager;
        }
        public IActionResult Index()
        {
            var kategoriler = kategoriManager.GetAll();
            return View(kategoriler);

        }
    }
}