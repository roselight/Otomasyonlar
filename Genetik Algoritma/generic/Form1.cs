using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int populasyonBuyuklugu, iterasyonSayisi = 0;
        double caprazlama, mutasyonOran, mutasyonKatsayi;
        Random rnd = new Random();
        FonkS fonksiyon = new EggHolder();
        KromozomS kromozom;
        BireySec bireySec;
        MutasyonS mutasyon;
        List<KromozomS> caprazlamakromozomList = new List<KromozomS>();
        KromozomS birey1, birey2, secilenCocukKromozom;
        List<KromozomS> yedekPopulasyon = new List<KromozomS>();
        List<double> enIyiUygunluklar = new List<double>();
        int mutasyonsayisi;
        int iterasyonSayisiText;
        public static int index;
        PopulasyonS populasyon = new PopulasyonS();
        public void bireyListele(DataGridView dtgrid)
        {
            dtgrid.Rows.Clear();
            dtgrid.Columns.Clear();
            int sutun = populasyon.Kromozomlistesi[0].Genler.Count;
            for (int i = 0; i < sutun; i++)
            {
                dtgrid.Columns.Add("", "");
            }
            dtgrid.Columns.Add("", "");
            for (int i = 0; i < populasyon.Kromozomlistesi.Count; i++)
            {
                dtgrid.Rows.Add();
                int j = 0;
                for (; j < sutun; j++)
                {
                    dtgrid.Columns[j].HeaderText = "Gen" + j;
                    dtgrid.Rows[i].Cells[j].Value = "" + populasyon.Kromozomlistesi[i].Genler[j].Gen;
                }
                if (populasyon.Kromozomlistesi.Count - 1 == i)
                    dtgrid.Columns[j].HeaderText = "UYGUNLUK DEĞERİ";
                dtgrid.Rows[i].Cells[j].Value = populasyon.Kromozomlistesi[i].UygDegeri;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            populasyonBuyuklugu = Convert.ToInt32(txtpop.Text);
            iterasyonSayisi = Convert.ToInt32(txtiterasyon.Text);
            caprazlama = Convert.ToDouble(txtcaprazlama.Text);
            mutasyonOran = Convert.ToDouble(txtmutoran.Text);
            mutasyonKatsayi = Convert.ToDouble(txtmutkatsayi.Text);
            caprazlamakromozomList.Clear();
            yedekPopulasyon.Clear();
            ilkPopulasyon();

            int programSonlanmaYuzdesi = 0;
            while (sonlanma_durumu())
            {
                try
                {
                    this.Text = "" + (programSonlanmaYuzdesi * 100) / iterasyonSayisiText;
                }
                catch (Exception) { }
                programSonlanmaYuzdesi++;
                iterasyon();
            }
            this.Text = "100";
            MessageBox.Show("En iyi birey uygunluk değeri : " + populasyon.Kromozomlistesi[0].UygDegeri);

            bireyListele(dtSonuc);
            Grafik grafik = new Grafik();
            grafik.cizGrafik1(enIyiUygunluklar, chart1, "populasyon degisimi", Color.Blue);

        }


        public void ilkPopulasyon()
        {
            FonkS fonksiyon = new EggHolder();
            for (int i = 0; i < populasyonBuyuklugu; i++)
            {
                kromozom = new KromozomS();
                for (int j = 0; j < fonksiyon.GenSayisi; j++)
                {
                    kromozom.genEkle(new GenS(rnd.NextDouble() * (fonksiyon.UstSinir - fonksiyon.AltSinir) + fonksiyon.AltSinir));
                }
                kromozom.UygDegeri = fonksiyon.hesapla(kromozom.Genler);
                populasyon.kromozomEkle(kromozom);
            }
            populasyon_sirala(populasyon.Kromozomlistesi);
            sonlanma_durumu();
            bireyListele(dtIterasyon);
            enIyiUygunluklar.Add(populasyon.Kromozomlistesi[0].UygDegeri);
        }
        public void iterasyon()
        {
          
            populasyon_sirala(populasyon.Kromozomlistesi);
            iterasyonSayisi++;
            bireySec = BireySec.yontem();
           
            listeKopyala();
            birey1 = bireySec.birey_sec(yedekPopulasyon);
         
            yedekPopulasyon.Remove(yedekPopulasyon[Form1.index]);
            birey2 = bireySec.birey_sec(yedekPopulasyon);
            CaprazlamaS cs = new CaprazlamaS();
            caprazlamakromozomList = cs.caprazla(birey1, birey2, caprazlama);

            mutasyonOran *= 100;

            int a = rnd.Next(0, 101);

            if (a >= 0 && a < mutasyonOran)
            {
                mutasyon = MutasyonS.mutasyon_yontem();
                caprazlamakromozomList = mutasyon.mutasyon_yap(caprazlamakromozomList, mutasyonKatsayi, fonksiyon.AltSinir, fonksiyon.UstSinir);
                mutasyonsayisi++;
            }

            foreach (var item in caprazlamakromozomList)
            {
                item.UygDegeri = fonksiyon.hesapla(item.Genler);
            }

            populasyon_sirala(caprazlamakromozomList);
            secilenCocukKromozom = caprazlamakromozomList[0];


            populasyon_sirala(populasyon.Kromozomlistesi);
            populasyon.Kromozomlistesi.Remove(populasyon.Kromozomlistesi[populasyon.Kromozomlistesi.Count - 1]);

            populasyon.kromozomEkle(secilenCocukKromozom);
            populasyon_sirala(populasyon.Kromozomlistesi);

            enIyiUygunluklar.Add(populasyon.Kromozomlistesi[0].UygDegeri);
        }

        void populasyon_sirala(List<KromozomS> list)
        {
            List<SiralamaUzaklıkHesapla> uzaklikNesnesi = new List<SiralamaUzaklıkHesapla>();
            for (int i = 0; i < list.Count; i++)
            {
                SiralamaUzaklıkHesapla a = new SiralamaUzaklıkHesapla(Math.Abs((double)(list[i].UygDegeri - fonksiyon.MinDeger)), list[i].UygDegeri);
                uzaklikNesnesi.Add(a);
            }
            for (int i = 0; i < uzaklikNesnesi.Count; i++)
            {
                for (int j = 0; j < uzaklikNesnesi.Count; j++)
                {
                    if (uzaklikNesnesi[i].uzaklik < uzaklikNesnesi[j].uzaklik)
                    {
                        SiralamaUzaklıkHesapla temp = uzaklikNesnesi[i];
                        uzaklikNesnesi[i] = uzaklikNesnesi[j];
                        uzaklikNesnesi[j] = temp;
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (uzaklikNesnesi[i].uygunluk == list[j].UygDegeri)
                    {
                        KromozomS temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }

            }
        }
        void listeKopyala()
        {
            yedekPopulasyon.Clear();
            for (int i = 0; i < populasyon.Kromozomlistesi.Count; i++)
            {
                yedekPopulasyon.Add(populasyon.Kromozomlistesi[i]);
            }
        }
        public bool sonlanma_durumu()
        {
            bool durum = true;
            for (int i = 0; i < populasyon.Kromozomlistesi.Count; i++)
            {
                if (/*(populasyon.KromozomList[i].UygulukDegeri> (fonksiyon.MinimumDegeri-0.0005) && populasyon.KromozomList[i].UygulukDegeri < (fonksiyon.MinimumDegeri + 0.0005))||*/populasyon.Kromozomlistesi[i].UygDegeri == fonksiyon.MinDeger)
                {
                    MessageBox.Show("uygunluk bitirdi iterasyon sayisi : " + iterasyonSayisi);
                    durum = false;
                }
                if (iterasyonSayisi == iterasyonSayisiText)
                {
                    durum = false;
                }
            }
            return durum;
        }



    }
    class SiralamaUzaklıkHesapla
    {
        public double uzaklik, uygunluk;
        public SiralamaUzaklıkHesapla(double uzaklik, double uygunluk)
        {
            this.uzaklik = uzaklik;
            this.uygunluk = uygunluk;
        }
    }
}