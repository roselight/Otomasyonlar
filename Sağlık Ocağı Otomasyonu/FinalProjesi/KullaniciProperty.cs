using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class KullaniciProperty
    {
        string kodu, ad, soyad, sifre, evtel, ceptel, adres, unvan, isebaslama, maas, dogumyeri, annead, babaad, cinsiyet, kangrubu, medenihal, dogumtarihi, tckimlikno, username;
        bool yetki;

        public bool Yetki
        {
            get { return yetki; }
            set { yetki = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Tckimlikno
        {
            get { return tckimlikno; }
            set
            {
                if (tckimlikno == string.Empty)
                {
                    throw new HataBosAlan();
                }
                else
                    tckimlikno = value;
            }
        }

        public string Dogumtarihi
        {
            get { return dogumtarihi; }
            set { dogumtarihi = value; }
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

        public string Babaad
        {
            get { return babaad; }
            set { babaad = value; }
        }

        public string Annead
        {
            get { return annead; }
            set { annead = value; }
        }

        public string Dogumyeri
        {
            get { return dogumyeri; }
            set { dogumyeri = value; }
        }

        public string Maas
        {
            get { return maas; }
            set { maas = value; }
        }

        public string Isebaslama
        {
            get { return isebaslama; }
            set { isebaslama = value; }
        }

        public string Unvan
        {
            get { return unvan; }
            set { unvan = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public string Ceptel
        {
            get { return ceptel; }
            set { ceptel = value; }
        }

        public string Evtel
        {
            get { return evtel; }
            set { evtel = value; }
        }


        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
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

        public string Kodu
        {
            get { return kodu; }
            set { kodu = value; }
        }
    }
}
