using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClassLib;
using System.IO;
namespace FormArayüzü
{
    public partial class evoto : DevExpress.XtraEditors.XtraForm
    {
        public evoto()
        {
            InitializeComponent();
        }
        public static Ev[] ev = new Ev[1000];
        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {

            KayitGoruntulecs k = new KayitGoruntulecs();
            FrmBlackBack f = new FrmBlackBack(k);
            f.ShowDialog();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            KayitEkle k = new KayitEkle();

            FrmBlackBack f = new FrmBlackBack(k);
            f.ShowDialog();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            KayitSil k = new KayitSil();
            FrmBlackBack f = new FrmBlackBack(k);
            f.ShowDialog();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            KayitGuncelle k = new KayitGuncelle();
            FrmBlackBack f = new FrmBlackBack(k);
            f.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            File.Delete("Kiralık.txt");
            File.Delete("Satılık.txt");
            for (int i = 0; i < KayitEkle.sayac; i++)
            {
                if (ev[i].Ilantürü == (İlanTürü)1)
                {
                    KiralıkEv ke = new KiralıkEv(ev[i]);
                    string bilgiler = ke.EvBilgileri() + Environment.NewLine;
                    File.AppendAllText("Kiralık.txt", bilgiler, Encoding.UTF8);
                }
                else if (ev[i].Ilantürü == (İlanTürü)0)
                {
                    SatılıkEv se = new SatılıkEv(ev[i]);
                    string bilgiler = se.EvBilgileri() + Environment.NewLine;
                    File.AppendAllText("Satılık.txt", bilgiler, Encoding.UTF8);
                }
            }




            this.Close();
        }

        private void evoto_Load(object sender, EventArgs e)
        {
            int say = 0;
            if (File.Exists("Satılık.txt"))
            {
                StreamReader sr = new StreamReader("Satılık.txt", Encoding.UTF7);
                string oku = sr.ReadLine();

                while (oku != null)
                {
                    string[] yaz = oku.Split(',');

                    ev[say] = new Ev();
                    ev[say].Emlakno = Convert.ToUInt32(yaz[0]);
                    ev[say].Ilantürü = (İlanTürü)byte.Parse(yaz[1]);
                    ev[say].Evtürü = (EvTürü)byte.Parse(yaz[2]);
                    ev[say].Aktifalan = bool.Parse(yaz[3]);
                    ev[say].Odasayisi = Int32.Parse(yaz[4]);
                    ev[say].Katno = byte.Parse(yaz[5]);
                    ev[say].Il = yaz[6];
                    ev[say].Ilce = yaz[7];
                    ev[say].Adres = yaz[8];
                    ev[say].Yapimtarihi = DateTime.Parse(yaz[9]);
                    ev[say].Alişfiyat = float.Parse(yaz[11]);
                    oku = sr.ReadLine(); say++;
                }
                sr.Close();

            }
           if (File.Exists("Kiralık.txt"))
            {
                StreamReader sr = new StreamReader("Kiralık.txt", Encoding.UTF7);
                string oku = sr.ReadLine();

                while (oku != null)
                {
                    string[] yaz = oku.Split(',');

                    ev[say] = new Ev();
                    ev[say].Emlakno = Convert.ToUInt32(yaz[0]);
                    ev[say].Ilantürü = (İlanTürü)byte.Parse(yaz[1]);
                    ev[say].Evtürü = (EvTürü)byte.Parse(yaz[2]);
                    ev[say].Aktifalan = bool.Parse(yaz[3]);
                    ev[say].Odasayisi = Int32.Parse(yaz[4]);
                    ev[say].Katno = byte.Parse(yaz[5]);
                    ev[say].Il = yaz[6];
                    ev[say].Ilce = yaz[7];
                    ev[say].Adres = yaz[8];
                    ev[say].Yapimtarihi = DateTime.Parse(yaz[9]);
                    ev[say].Depozito = float.Parse(yaz[11]);
                    oku = sr.ReadLine(); say++;
                }
                sr.Close();
                
            }KayitEkle.sayac = say;
        }

        private void btnkucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnbuyut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}


