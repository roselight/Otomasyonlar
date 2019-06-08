using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLib
{
    public enum İlanTürü : byte
    {
        Satılık=1,
        Kiralık=0
    }
   public  enum EvTürü : byte
    {
        Daire=0,
        Müstakil=1,
        Bahçeli=2,
        Dublex=3,
        Havuzlu=4
    }
   public class Ev
    {
        private EvTürü evtürü;

        public EvTürü Evtürü
        {
            get { return evtürü; }
            set { evtürü = value; }
        }


        private İlanTürü ilantürü;

        public İlanTürü Ilantürü
        {
            get { return ilantürü; }
            set { ilantürü = value; }
        }
        protected int odasayisi;
        protected byte katno;
       protected int EvinYasi;
       private string adres;

       public string Adres
       {
           get { return adres; }
           set { adres = value; }
       }
       private string ilce;

       public string Ilce
       {
           get { return ilce; }
           set { ilce = value; }
       }
       private string il;

       public string Il
       {
           get { return il; }
           set { il = value; }
       } DateTime yapimtarihi;
        protected float depozito, kira, alişfiyat;
       protected  uint emlakno;
       protected bool aktifalan;
        Exception hata = new Exception("Girilen değer 0-255 arasında olmalıdır.");



        public int EvinYasi1
        {
           
            get { 
                
              return DateTime.Now.Year-Yapimtarihi.Year;
                  }
           

        }
        public byte Katno
        {
            get { return katno; }
            set { katno = value; }

        }

        public int Odasayisi
        {
            get { return odasayisi; }
            set
            {
                if (value < 0)
                {
                    throw new hata(value);
                }
                else
                odasayisi = value; }
        }


      


        public DateTime Yapimtarihi
        {
            get { return yapimtarihi; }
            set { yapimtarihi = value; }
        }


        public uint Emlakno
        {

            get { return emlakno; }
            set
            {

                emlakno = value;
            }

        }


        public float Alişfiyat
        {
            get { return alişfiyat; }
            set { alişfiyat = value; }
        }

        public float Kira
        {
            get { return kira; }
           
        }

        public float Depozito
        {
            get { return depozito; }
            set { depozito = value; }
        }


        public bool Aktifalan
        {
            get { return aktifalan; }
            set { aktifalan = value; }
        }

        public uint EmlaknoUret()
        {
            ArrayList essiz = new ArrayList();
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            if (essiz.Contains(random))
            {
                EmlaknoUret();
            }
            else
            {
                essiz.Add(random);
            }
            emlakno = random;
            return emlakno;
        }
      
         public Ev()
           {
             
              
           }
           public Ev(int odas,byte katn)
           {
               Odasayisi = odas;
               Katno = katn;
              
               
           }
           public Ev(int odas,byte katn,DateTime ypmtrh,float depozt,float alisf,bool alan)
           {
               Odasayisi = odas;
               Katno = katn;
               Yapimtarihi = ypmtrh;
               Depozito = depozt;
               Alişfiyat = alisf;
               Aktifalan = alan;
               
           }
           public virtual string EvBilgileri()
           {
               string bilgiler = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", Emlakno, Aktifalan, Odasayisi, Katno, Il, Yapimtarihi,Kira,Depozito,Alişfiyat);
               return bilgiler;
           }
           public float FiyatHesapla()
           {
               if (File.Exists("room_cost.txt") == true)
               {
                   string[] dizi = new string[] { ":" };
                   string[] bilgi = new string[2];
                   StreamReader sr = new StreamReader("room_cost.txt",Encoding.UTF7);
                   string satir = sr.ReadLine();
                   while (satir != null)
                   {
                       bilgi = satir.Split(dizi, StringSplitOptions.RemoveEmptyEntries);
                       if (bilgi[0] ==EvTürü.Bahçeli.ToString())
                       {
                           kira = (byte.Parse(bilgi[1]) * Odasayisi);
                           break;
                           
                       }
                       else if (bilgi[0] == EvTürü.Daire.ToString())
                       {
                           kira = (byte.Parse(bilgi[1]) * Odasayisi);
                           break;

                       }
                       else if (bilgi[0] == EvTürü.Dublex.ToString())
                       {
                           kira = (byte.Parse(bilgi[1]) * Odasayisi);
                           break;

                       }
                       else if (bilgi[0] == EvTürü.Havuzlu.ToString())
                       {
                           kira = (byte.Parse(bilgi[1]) * Odasayisi);
                           break;

                       }
                       else if (bilgi[0] == EvTürü.Müstakil.ToString())
                       {
                           kira = (byte.Parse(bilgi[1]) * Odasayisi);
                           break;
                       }

                       satir = sr.ReadLine();
                   }
                return kira;
                   
               }
               else
               {
                   kira = Odasayisi * 200;
                   return kira;
               }
               }
              
           }
 
    public class KiralıkEv:Ev
    {
        public KiralıkEv(Ev e):base()
        {
            Emlakno = e.Emlakno;
            Ilantürü = e.Ilantürü;
            Evtürü=e.Evtürü;
            Aktifalan = e.Aktifalan;
            Odasayisi=e.Odasayisi ;
            Depozito = e.Depozito;
            Yapimtarihi=e.Yapimtarihi;
            Adres=e.Adres;
            Katno=e.Katno;
            Il=e.Il;
            Ilce=e.Ilce;

        }

        public override string EvBilgileri()
        {
            string bilgiler = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", Emlakno, Ilantürü.ToString("d"), Evtürü.ToString("d"), Aktifalan, Odasayisi, Katno, Il, Ilce, Adres, Yapimtarihi, EvinYasi1,Depozito,Kira);
            return bilgiler; 
        }
        
    }
    public class SatılıkEv:Ev
    {
        public SatılıkEv(Ev e):base()
        {
            Emlakno = e.Emlakno;
            Ilantürü = e.Ilantürü;
            Evtürü = e.Evtürü;
            Aktifalan = e.Aktifalan;
            Odasayisi = e.Odasayisi;
            Alişfiyat = e.Alişfiyat;
            Yapimtarihi = e.Yapimtarihi;
            Adres = e.Adres;
            Katno = e.Katno;
            Il = e.Il;
            Ilce = e.Ilce;
        }
        public override string EvBilgileri()
        {
            string bilgiler = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", Emlakno,Ilantürü.ToString("d"), Evtürü.ToString("d"), Aktifalan, Odasayisi, Katno, Il, Ilce, Adres, Yapimtarihi, EvinYasi1, Alişfiyat);
            return bilgiler; 
        }
    }
    }

   
