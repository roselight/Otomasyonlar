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
    public partial class KayitGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public KayitGuncelle()
        {
            InitializeComponent();
        }
        int index = 0;
        void yazdır()
        {
            try
            {
          
                for (int i = 0; i < KayitEkle.sayac; i++)
                {
                    if (evoto.ev[i].Emlakno == UInt32.Parse(txtemlakno.Text))
                    {
                        index = i;
                        txtemlakno.Text = evoto.ev[i].Emlakno.ToString();
                        cmbilanturu.Text = evoto.ev[i].Ilantürü.ToString();
                        cmbevturu.Text = evoto.ev[i].Evtürü.ToString();
                        cmbil.Text = evoto.ev[i].Il.ToString();
                        cmbilce.Text = evoto.ev[i].Ilce.ToString();
                        cmbaktifalan.Text = evoto.ev[i].Aktifalan.ToString();
                        txtodas.Text = evoto.ev[i].Odasayisi.ToString();
                        dtyapimtarihi.Text = evoto.ev[i].Yapimtarihi.ToString();
                        txtadres.Text = evoto.ev[i].Adres.ToString();
                        txtkatno.Text = evoto.ev[i].Katno.ToString();


                        if (evoto.ev[i].Ilantürü.ToString() == "Satılık")
                        {
                            txtalisfiyati.Text = evoto.ev[i].Alişfiyat.ToString();
                        }
                        else if (evoto.ev[i].Ilantürü.ToString() == "Kiralık")
                        {
                            txtkira.Text = evoto.ev[i].Kira.ToString();
                            txtdepoizto.Text = evoto.ev[i].Depozito.ToString();
                        }
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Hatalı Veri Girişi","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void Kaydet()
        {

            evoto.ev[index].Emlakno = Convert.ToUInt32(txtemlakno.Text);
            evoto.ev[index].Ilantürü = (İlanTürü)cmbilanturu.SelectedIndex;
            evoto.ev[index].Evtürü = (EvTürü)cmbevturu.SelectedIndex;
            evoto.ev[index].Aktifalan = Convert.ToBoolean(cmbaktifalan.Text);
            evoto.ev[index].Odasayisi = Convert.ToByte(txtodas.Text);
            evoto.ev[index].Yapimtarihi = Convert.ToDateTime(dtyapimtarihi.Text);
            evoto.ev[index].Adres = txtadres.Text;
            evoto.ev[index].Katno = Convert.ToByte(txtkatno.Text);
            if(cmbil.Text!=evoto.ev[index].Il)
            {
            string il = cmbil.Text;
            string[] a = new string[2];
            string[] d = new string[] { "\t" };
            a = il.Split(d, StringSplitOptions.RemoveEmptyEntries);
            evoto.ev[index].Il = a[1]; }
            evoto.ev[index].Il = cmbil.Text;
            evoto.ev[index].Ilce = cmbilce.Text;
            if (cmbilanturu.SelectedIndex == 0)
            {
                evoto.ev[index].Alişfiyat = float.Parse(txtalisfiyati.Text);
            }
            else if (cmbilanturu.SelectedIndex == 1)
            {
                evoto.ev[index].Depozito = float.Parse(txtdepoizto.Text);
            }
        }
        void ilgetir()
        {
            string il = cmbil.Text;
            string[] a = new string[2];
            string[] d = new string[] { "\t" };
            a = il.Split(d, StringSplitOptions.RemoveEmptyEntries);
            if (File.Exists("ilceler.txt") == true)
            {
                string[] dizi = new string[] { ":", "\t" };
                string[] bilgi = new string[2];
                StreamReader sr = new StreamReader("ilceler.txt", Encoding.GetEncoding("windows-1254"));
                string satir = sr.ReadLine();
                while (satir != null)
                {
                    bilgi = satir.Split(dizi, StringSplitOptions.RemoveEmptyEntries);
                    if (bilgi[0] == a[0])
                    {

                        cmbilce.Properties.Items.Add(bilgi[1]);
                    }
                    satir = sr.ReadLine();
                }
            }
        }

        private void txtemlakno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                

                yazdır();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bilgileri Güncellenecek.Onaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            { Kaydet();
            MessageBox.Show("İşlem Başarılı", "BİLGİLENDİRME");
            this.Close();
               /* foreach(Control item in)
                {
                    if(item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        txt.Clear();

                    }
                    if(item is DevExpress.XtraEditors.ComboBox)
                    {
                        DevExpress.XtraEditors.ComboBox cmb = (DevExpress.XtraEditors.ComboBox)item;
                        cmb.DeselectAll();
                    }
                }*/
            }
            
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilgetir();
        }
    }
}