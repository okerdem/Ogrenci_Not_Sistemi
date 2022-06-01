using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityNotlar
    {
        int _ogrenciid;
        int _sinav1;
        int _sinav2;
        int _proje;
        double _ortalama;
        string _durum;
        string _ad;
        string _soyad;

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public int Ogrenciid { get => _ogrenciid; set => _ogrenciid = value; }
        public int Sinav1 { get => _sinav1; set => _sinav1 = value; }
        public int Sinav2 { get => _sinav2; set => _sinav2 = value; }
        public int Proje { get => _proje; set => _proje = value; }
        public double Ortalama { get => _ortalama; set => _ortalama = value; }
        public string Durum { get => _durum; set => _durum = value; }
    }
}
