using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class SqlKullanici
    {

        public bool kulllanicigiris(KullaniciProperty k)
        {
            bool a=false;
            Csabit.Baglan();
            SqlCommand komut = new SqlCommand("Select yetki From kullanici Where username='" + k.Username + "'and sifre='" + k.Sifre + "'", Csabit.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if("true"==dr["yetki"].ToString() ||"True"==dr["yetki"].ToString() )
                {
                    a = true;
                }
             
            }
            else
            {
                a = false;
            }
            dr.Close();
            return a;
        }


        public void KullaniciEkle(KullaniciProperty k)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;

            sorgu.CommandText = "Insert Into kullanici (kodu,ad,soyad,sifre,yetki,evtel,ceptel,adres,unvan,isebaslama,maas,dogumyeri,annead,babaad,cinsiyet,kangrubu,medenihal,dogumtarihi,tckimlikno,username) Values ('" + k.Kodu + "','" + k.Ad + "','" + k.Soyad + "','" + k.Sifre + "','true','" + k.Sifre + "','" + k.Ceptel + "','" + k.Adres + "','" + k.Unvan + "','" + Convert.ToDateTime(k.Isebaslama) + "','" + k.Maas + "','" + k.Dogumyeri + "','" + k.Annead + "','" + k.Babaad + "','" + k.Cinsiyet + "','" + k.Kangrubu + "','" + k.Medenihal + "','" + Convert.ToDateTime(k.Dogumtarihi) + "','" + k.Tckimlikno + "','" + k.Username + "')";
            sorgu.ExecuteNonQuery();
            Csabit.Kapat();
        }

        public void KullaniciSil(KullaniciProperty k)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
            sorgu.CommandText = "Delete kullanici where kodu='" + k.Kodu + "'";
            Csabit.Kapat();
        }
      
        public int KullaniciKoduCek()
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
            sorgu.CommandText = "select  top 1 kodu from kullanici order by kodu desc SELECT SCOPE_IDENTITY()";
            object id = sorgu.ExecuteScalar();
            Int32 deger = Convert.ToInt32(id);
            deger = deger + 1;
            Csabit.Kapat();
            return deger;
        }
    }
}
