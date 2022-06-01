using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityYonetici
    {
        int _id;
        string _kullaniciadi;
        string _sifre;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Kullaniciadi
        {
            get { return _kullaniciadi; }
            set { _kullaniciadi = value; }
        }

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }
    }
}
