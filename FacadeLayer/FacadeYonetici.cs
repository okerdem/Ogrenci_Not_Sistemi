using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace FacadeLayer
{
    public class FacadeYonetici
    {
        public bool Kontrol(EntityYonetici deger)
        {
            SqlCommand komut = new SqlCommand("yoneticilistesi", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()&& deger.Kullaniciadi == dr[1].ToString() && deger.Sifre == dr[2].ToString())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
    }
}
