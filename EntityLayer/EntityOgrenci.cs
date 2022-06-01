using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        int _id;
        string _ad;
        string _soyad;
        string _fotograf;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string Fotograf
        {
            get { return _fotograf; }
            set { _fotograf = value; }
        }
    }
}
