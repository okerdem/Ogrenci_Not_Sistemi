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
    public class FacadeOgrenci
    {
        public int Ekle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("ogrenciekle", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("ad", deger.Ad);
            komut.Parameters.AddWithValue("soyad", deger.Soyad);
            komut.Parameters.AddWithValue("fotograf", deger.Fotograf);

            return komut.ExecuteNonQuery();
        }

        public bool Sil(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("ogrencisil", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("id", deger.Id);

            return komut.ExecuteNonQuery() > 0;
        }

        public bool Guncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("ogrenciguncelle", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("ad", deger.Ad);
            komut.Parameters.AddWithValue("soyad", deger.Soyad);
            komut.Parameters.AddWithValue("fotograf", deger.Fotograf);
            komut.Parameters.AddWithValue("id", deger.Id);

            return komut.ExecuteNonQuery() > 0;
        }

        public List<EntityOgrenci> Listele()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("ogrencilistesi", SqlBaglantisi.con);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                EntityOgrenci deger = new EntityOgrenci();
                deger.Id = Convert.ToInt16(dr["id"]);
                deger.Ad = Convert.ToString(dr["ad"]);
                deger.Soyad = Convert.ToString(dr["soyad"]);
                deger.Fotograf = Convert.ToString(dr["fotograf"]);

                degerler.Add(deger);
            }
            dr.Close();

            return degerler;
        }
    }
}
