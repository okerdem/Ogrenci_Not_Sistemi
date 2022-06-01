using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLYonetici
    {
        FacadeYonetici fy = new FacadeYonetici();
        public bool Kontrol(EntityYonetici deger)
        {
            return fy.Kontrol(deger);
        }
    }
}
