using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLNotlar
    {
        FacadeNotlar fn = new FacadeNotlar();

        public bool Guncelle(EntityNotlar deger)
        {
            if (deger.Ogrenciid != 0 &&deger.Sinav1>=0&&deger.Sinav1<=100
                && deger.Sinav2 >= 0 && deger.Sinav2 <= 100 && deger.Proje >= 0 && deger.Proje <= 100)
            {
                return fn.Guncelle(deger);
            }
            else return false;
        }

        public List<EntityNotlar> Listele()
        {
            return fn.listele();
        }
    }
}
