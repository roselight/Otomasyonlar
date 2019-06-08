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
using System.IO;
using ClassLib;

namespace FormArayüzü
{
    public partial class KayitEkle : DevExpress.XtraEditors.XtraForm
    {
        public KayitEkle()
        {
            InitializeComponent();
            emlaknoal();
            
        }
       public static int sayac = 0;
        Ev e = new Ev();
        void emlaknoal()
        {
            txtemlakno.Text = e.EmlaknoUret().ToString();
          
           
        }
        void evinyasi()
        {
            txtevinyas.Text = e.EvinYasi1.ToString();
        }
        void kiragetir()
        {
            
            e.Odasayisi = Convert.ToInt32(txtodas.Text);
            
            
            txtkira.Text = e.FiyatHesapla().ToString();
        }
        private void Kaydet()
        {
           
           evoto.ev[sayac]=new Ev();
           evoto.ev[sayac].Emlakno = Convert.ToUInt32(txtemlakno.Text);
           evoto.ev[sayac].Ilantürü = (İlanTürü)cmbilanturu.SelectedIndex;
           evoto.ev[sayac].Evtürü = (EvTürü)cmbevturu.SelectedIndex;
           evoto.ev[sayac].Aktifalan = Convert.ToBoolean(cmbaktifalan.Text);
          
           evoto.ev[sayac].Odasayisi = Convert.ToInt32(txtodas.Text);
               
         
        
           
          
           evoto.ev[sayac].Yapimtarihi = Convert.ToDateTime(dtyapimtarihi.Text);
           evoto.ev[sayac].Adres = txtadres.Text;
           evoto.ev[sayac].Katno = Convert.ToByte(txtkatno.Text);
           string il = cmbil.Text;
           string[] a = new string[2];
           string[] d = new string[] { "\t" };
           a = il.Split(d, StringSplitOptions.RemoveEmptyEntries);
           evoto.ev[sayac].Il =a[1];
           evoto.ev[sayac].Ilce = cmbilce.Text;
            if(cmbilanturu.SelectedIndex==0)
            {
                evoto.ev[sayac].Alişfiyat = float.Parse(txtalisfiyati.Text);
            }
            else if(cmbilanturu.SelectedIndex==1)
            {
                evoto.ev[sayac].Depozito = float.Parse(txtdepoizto.Text);
            }
         
           sayac++;

            
        }
       void ilgetir()
        { 
            string il = cmbil.Text;
            string[] a = new string[2];
            string[] d = new string[] { "\t" };
            a = il.Split(d, StringSplitOptions.RemoveEmptyEntries);
            if (File.Exists("ilceler.txt") == true)
            {
                string[] dizi = new string[] { ":","\t" };
                string[] bilgi = new string[2];
                StreamReader sr = new StreamReader("ilceler.txt", Encoding.GetEncoding("windows-1254"));
                string satir = sr.ReadLine();
                while (satir != null)
                {
                    bilgi = satir.Split(dizi, StringSplitOptions.RemoveEmptyEntries);
                    if (bilgi[0] ==a[0])
                    {
                        
                        cmbilce.Properties.Items.Add(bilgi[1]);
                    }
                    satir=sr.ReadLine();
                }
            }
        }


        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Text = "";
            cmbilce.Properties.Items.Clear();
            ilgetir();
        }

        private void cmbilanturu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtkira.Enabled = false;
            txtdepoizto.Enabled = false;
            txtalisfiyati.Enabled = false;
            string a = cmbilanturu.Text;
            if(a=="Satılık")
            {
                txtalisfiyati.Enabled = true;
            }
           else if(a=="Kiralık")
            {
                txtdepoizto.Enabled=true;
                txtkira.Enabled = true;
            }

        }

     

        private void simpleButton3_Click(object sender, EventArgs e)
        {
                this.Close();
           
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
                Kaydet();
            
          
        }

        private void txtodas_Click(object sender, EventArgs e)
        {

        }

        private void txtodas_Leave(object sender, EventArgs e)
        {
            try { kiragetir(); }
            catch(hata h)
            {
                MessageBox.Show(h.ToString());
                txtodas.Text = "";
            }
        }

        private void dtyapimtarihi_Leave(object sender, EventArgs e)
        {
          //  evinyasi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

           
            
        }

        private void txtodas_EditValueChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}