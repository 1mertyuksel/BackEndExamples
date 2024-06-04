using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.BL.Managers.Concrete
{
    public class KategoriManager : ManagerBase<Kategori>, IKategoriManager
    {
        public ICollection<Kategori> KritikStokSeviyesiAltindakiler()
        {
            throw new NotImplementedException();
        }

        public override int Insert(Kategori input)
        {
            #region Kategori Adi Boşmu Kontrolu

            if (string.IsNullOrEmpty(input.KategoriAdi))
            {
                throw new Exception("Urun Adi Boş Olamaz ");
            }

            if (input.KategoriAdi.Trim().Length < 2)
            {
                throw new Exception("Kategori Adi en Az 2 karekter olmalidir ");
            }
            #endregion

            
            return base.Insert(input);

        }

         
    }
}
