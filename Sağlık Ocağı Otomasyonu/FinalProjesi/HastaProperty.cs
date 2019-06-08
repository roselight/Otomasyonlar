using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
   public class HastaProperty
    {
        string tckimlikno, dosyano, ad, soyad, dogumyeri, dogumtarihi, babaadi, anneadi, cinsiyet, kangrubu, medenihal, adres, tel, kurumsicilno, kurumadi, yakintel, yakinkurumsicilno, yakınkurumadi;
        int secim;

        string sevktarihi, poliklik, saat, yapilanislem, drkodu, miktar, birimfiyat, sira, toplamtutar, taburcu, cikistarihi, odeme;

        public string Odeme
        {
            get { return odeme; }
            set { odeme = value; }
        }

        public string Cikistarihi
        {
            get { return cikistarihi; }
            set { cikistarihi = value; }
        }

        public string Taburcu
        {
            get { return taburcu; }
            set { taburcu = value; }
        }

        public string Toplamtutar
        {
            get { return toplamtutar; }
            set { toplamtutar = value; }
        }

        public string Sira
        {
            get { return sira; }
            set { sira = value; }
        }

        public string Birimfiyat
        {
            get { return birimfiyat; }
            set { birimfiyat = value; }
        }

        public string Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        public string Drkodu
        {
            get { return drkodu; }
            set { drkodu = value; }
        }

        public string Yapilanislem
        {
            get { return yapilanislem; }
            set { yapilanislem = value; }
        }

        public string Saat
        {
            get { return saat; }
            set { saat = value; }
        }

        public string Poliklik
        {
            get { return poliklik; }
            set { poliklik = value; }
        }

        public string Sevktarihi
        {
            get { return sevktarihi; }
            set { sevktarihi = value; }
        }
        public int Secim
        {
            get { return secim; }
            set { secim = value; }
        }

        public string Yakınkurumadi
        {
            get { return yakınkurumadi; }
            set { yakınkurumadi = value; }
        }

        public string Yakinkurumsicilno
        {
            get { return yakinkurumsicilno; }
            set { yakinkurumsicilno = value; }
        }

        public string Yakintel
        {
            get { return yakintel; }
            set { yakintel = value; }
        }

        public string Kurumadi
        {
            get { return kurumadi; }
            set { kurumadi = value; }
        }

        public string Kurumsicilno
        {
            get { return kurumsicilno; }
            set { kurumsicilno = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public string Medenihal
        {
            get { return medenihal; }
            set { medenihal = value; }
        }

        public string Kangrubu
        {
            get { return kangrubu; }
            set { kangrubu = value; }
        }

        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public string Anneadi
        {
            get { return anneadi; }
            set { anneadi = value; }
        }

        public string Babaadi
        {
            get { return babaadi; }
            set { babaadi = value; }
        }

        public string Dogumtarihi
        {
            get { return dogumtarihi; }
            set { dogumtarihi = value; }
        }

        public string Dogumyeri
        {
            get { return dogumyeri; }
            set { dogumyeri = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Dosyano
        {
            get { return dosyano; }
            set { dosyano = value; }
        }

        public string Tckimlikno
        {
            get { return tckimlikno; }
            set
            {
                if (tckimlikno == "")
                {
                    throw new HataBosAlan();
                }
                else
                    tckimlikno = value;
            }
        }
    }
}
