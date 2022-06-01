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
    public class FacadeNotlar
    {
        public bool Guncelle(EntityNotlar deger)
        {
            SqlCommand komut = new SqlCommand("notguncelle", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ogrenciid", deger.Ogrenciid);
            komut.Parameters.AddWithValue("@sinav1", deger.Sinav1);
            komut.Parameters.AddWithValue("@sinav2", deger.Sinav2);
            komut.Parameters.AddWithValue("@proje", deger.Proje);

            return komut.ExecuteNonQuery() > 0;
        }

        public List<EntityNotlar> listele()
        {
            List<EntityNotlar> degerler = new List<EntityNotlar>();
            SqlCommand komut = new SqlCommand("notlistesi", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityNotlar deger = new EntityNotlar();
                deger.Ogrenciid = Convert.ToInt16(dr["Öğrenci id"]);
                deger.Ad = dr["Ad"].ToString();
                deger.Soyad = dr["Soyad"].ToString();
                deger.Sinav1 = Convert.ToInt16(dr["Sınav 1"]);
                deger.Sinav2 = Convert.ToInt16(dr["Sınav 2"]);
                deger.Proje = Convert.ToInt16(dr["Proje"]);
                deger.Ortalama = Convert.ToDouble(dr["Ortalama"]);
                deger.Durum = dr["Durum"].ToString();
                degerler.Add(deger);
            }
            dr.Close();
            return degerler;
        }
    }
}
