using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        FacadeOgrenci fo = new FacadeOgrenci();

        public int Ekle(EntityOgrenci deger)
        {
            if (deger.Ad != null && deger.Soyad != null)
            {
                return fo.Ekle(deger);
            }
            else return -1;
        }

        public bool Guncelle(EntityOgrenci deger)
        {
            if (deger.Id != 0)
            {
                return fo.Guncelle(deger);
            }
            else return false;
        }

        public bool Sil(EntityOgrenci deger)
        {
            if (deger.Id != 0)
            {
                return fo.Sil(deger);
            }
            else return false;
        }

        public List<EntityOgrenci> Listele()
        {
            return fo.Listele();
        }
    }
}
