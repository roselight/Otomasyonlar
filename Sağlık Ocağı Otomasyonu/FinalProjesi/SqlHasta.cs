using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class SqlHasta
    {


        public void HastaEkle(HastaProperty hb)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;

            sorgu.CommandText = "Insert Into hasta (tckimlikno,dosyano,ad,soyad,dogumyeri,dogumtarihi,babaadi,anneadi,cinsiyet,kangrubu,medenihal,adres,tel,kurumsicilno,kurumadi,yakintel,yakınkurumadi) Values ('" + hb.Tckimlikno + "','" + hb.Dosyano + "','" + hb.Ad + "','" + hb.Soyad + "','" + hb.Dogumyeri + "','" + hb.Dogumtarihi + "','" + hb.Babaadi + "','" + hb.Anneadi + "','" + hb.Cinsiyet + "','" + hb.Kangrubu + "','" + hb.Medenihal + "','" + hb.Adres + "','" + hb.Tel + "','" + hb.Kurumsicilno + "','" + hb.Kurumadi + "','" + hb.Yakintel + "','" + hb.Yakınkurumadi + "')";
            sorgu.ExecuteNonQuery();
            Csabit.Kapat();
        }



        public void HastaBilgileriCek(HastaProperty hb, int d)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
            sorgu.CommandText = "select * from hasta where dosyano='" + d + "'";
            sorgu.CommandType = CommandType.Text;
            SqlDataReader dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                hb.Dosyano = dr["dosyano"].ToString();
                hb.Ad = dr["ad"].ToString();
                hb.Soyad = dr["soyad"].ToString();
                hb.Tckimlikno = dr["tckimlikno"].ToString();
                hb.Kurumadi = dr["kurumadi"].ToString();
                hb.Dogumyeri = dr["dogumyeri"].ToString();
                hb.Dogumtarihi = dr["dogumtarihi"].ToString();
                hb.Babaadi = dr["babaadi"].ToString();
                hb.Anneadi = dr["anneadi"].ToString();
                hb.Cinsiyet = dr["cinsiyet"].ToString();
                hb.Kangrubu = dr["kangrubu"].ToString();
                hb.Medenihal = dr["medenihal"].ToString();
                hb.Adres = dr["adres"].ToString();
                hb.Tel = dr["tel"].ToString();
                hb.Kurumsicilno = dr["kurumsicilno"].ToString();
                hb.Yakintel = dr["yakintel"].ToString();
                hb.Yakinkurumsicilno = dr["yakinkurumsicilno"].ToString();
                hb.Yakınkurumadi = dr["yakınkurumadi"].ToString();
            }
            dr.Close();
            sorgu.ExecuteNonQuery();


            Csabit.Kapat();
        }


        public int DosyaNoCek()
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
            sorgu.CommandText = "select  top 1 dosyano from hasta order by dosyano desc SELECT SCOPE_IDENTITY()";
            object id = sorgu.ExecuteScalar();


            Int32 deger = Convert.ToInt32(id);
            deger = deger + 1;

            Csabit.Kapat();
            return deger;
        }

        public void DosyaBilgisiCek(HastaProperty h)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
            sorgu.CommandText = "select ad,soyad,kurumadi,s.sevktarihi from hasta h inner join sevk s on s.dosyano=h.dosyano where h.dosyano='" + h.Dosyano + "'";
            sorgu.CommandType = CommandType.Text;
            SqlDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                h.Ad = dr["ad"].ToString();
                h.Soyad = dr["soyad"].ToString();
                h.Kurumadi = dr["kurumadi"].ToString();
                h.Sevktarihi = dr["sevktarihi"].ToString();

            }

            dr.Close();
            sorgu.ExecuteNonQuery();


            Csabit.Kapat();
        }

        public DataTable OncekiIslemGit(HastaProperty cs)
        {

            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
            sorgu.CommandText = "select poliklinik AS POLİKLİNİK,sira as [SIRA NO],saat as SAAT,yapilanislem as [YAPILAN İŞLEM],drkod AS [DR KODU],miktar AS MİKTAR,birimfiyat AS [BİRİM FİYATI] from sevk s inner join cikis c on s.dosyano=c.dosyano where c.sevktarihi='" + cs.Sevktarihi + "' and s.dosyano='"+cs.Dosyano+"'";
            DataTable dt = new DataTable("table1");
            SqlDataAdapter dta = new SqlDataAdapter(sorgu);
            dta.Fill(dt);
            Csabit.Kapat();
            return dt;

        }

        public DataTable Bul(HastaProperty h)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;
       
           switch(h.Secim)
           {
               case 0:
                   sorgu.CommandText = "Select * from hasta where ad LIKE '%" + h.Ad + "%' or soyad LIKE '%" + h.Soyad + "%'";
                   break;
               case 10:
                   sorgu.CommandText = "Select * from hasta where ad LIKE '%" + h.Ad + "%' and soyad LIKE '%"+ h.Soyad+"%'";
                   break;
               case 1:
                   sorgu.CommandText = "Select * from hasta where tckimlikno LIKE '%" + h.Tckimlikno + "%'";
                   break;
               case 2:
                   sorgu.CommandText = "Select * from hasta where kurumsicilno LIKE '%" + h.Kurumsicilno + "%'";
                   break;
               case 3:
                   sorgu.CommandText = "Select * from hasta where dosyano LIKE '%" + h.Dosyano + "%'";
                   break;
           }
           
           DataTable dt = new DataTable("hasta");
           SqlDataAdapter da=new SqlDataAdapter(sorgu);
           da.Fill(dt);
           Csabit.Kapat();
            return dt;
        }
        public void hastaCikisTarihi(HastaProperty h)
        {
              Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;

            sorgu.CommandText = "Insert Into cikis values('" + h.Dosyano + "','" + h.Sevktarihi + "','" + h.Cikistarihi + "','" + h.Odeme + "','" + h.Toplamtutar + "')";
            Csabit.Kapat();
        }
        public DataTable RaporSorgula(HastaProperty h,int kosul)
        {
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;

            switch (h.Secim)
            {
                case 0://taburcu olmuş
                    sorgu.CommandText = "select * from hasta h inner join sevk s on h.dosyano=s.dosyano where sevktarihi between  '"+h.Sevktarihi+"' and '"+h.Cikistarihi+"' and taburcu='true'";
                    break;
                case 1://olmamış
                    sorgu.CommandText = "select * from hasta h inner join sevk s on h.dosyano=s.dosyano where sevktarihi= '"+h.Sevktarihi+"' and taburcu='false'";
                    break;
              
                case 2://hepsi
                    sorgu.CommandText = "select * from hasta h inner join sevk s on h.dosyano=s.dosyano where sevktarihi= '" + h.Sevktarihi + "'"; 
                    break;
             
            }

            DataTable dt = new DataTable("hasta");
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            da.Fill(dt);
            Csabit.Kapat();
            return dt;
        }

        public void SevkEkle(HastaProperty h)
        {  
            Csabit.Baglan();
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection = Csabit.baglanti;

            sorgu.CommandText = "Insert Into sevk Values ('" + h.Sevktarihi + "','" + h.Dosyano + "','" + h.Poliklik + "','" + h.Saat + "','" + h.Yapilanislem + "','" + h.Drkodu + "','" + h.Miktar + "','" + h.Birimfiyat + "','" +h.Sira + "','" + h.Toplamtutar + "','true')";
            sorgu.ExecuteNonQuery();
            Csabit.Kapat();
            
        }
    }
}
