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

namespace FormArayüzü
{
    public partial class KayitSil : DevExpress.XtraEditors.XtraForm
    {
        public KayitSil()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            
        }
        DataTable dt = new DataTable();
        private void KayitSil_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Emlak Numarası", typeof(uint));
            dt.Columns.Add("İlan Türü", typeof(string));
            dt.Columns.Add("Ev Türü", typeof(string));
            dt.Columns.Add("Güncel Durumu", typeof(string));
            dt.Columns.Add("Oda Sayısı", typeof(string));
            dt.Columns.Add("Yapım Tarihi", typeof(DateTime));
            dt.Columns.Add("Adres", typeof(string));
            dt.Columns.Add("İl", typeof(string));
            dt.Columns.Add("İlçe", typeof(string));
            dt.Columns.Add("Kat No", typeof(byte));
            dt.Columns.Add("Depozito", typeof(float));
            dt.Columns.Add("Kira", typeof(float));
            dt.Columns.Add("Alış Fiyatı", typeof(float));
            gridControl1.DataSource = dt; 
        }
        void ekle()
        {

            for (int i = 0; i < KayitEkle.sayac; i++)
            {
                if(evoto.ev[i].Emlakno==UInt32.Parse(txtsil.Text))
                {
                    index = i;
                dt.Rows.Add(evoto.ev[i].Emlakno, evoto.ev[i].Ilantürü, evoto.ev[i].Evtürü, evoto.ev[i].Aktifalan, evoto.ev[i].Odasayisi, evoto.ev[i].Yapimtarihi, evoto.ev[i].Adres, evoto.ev[i].Il, evoto.ev[i].Ilce, evoto.ev[i].Katno, evoto.ev[i].Depozito, evoto.ev[i].Kira, evoto.ev[i].Alişfiyat);
                gridControl1.DataSource = dt;
                }
            }
                
            
        }
        int index = 0;
        void sil()
        {
            evoto.ev[index].Aktifalan = false;
        }

        private void txtsil_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtsil_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                ekle();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sil();
        }
    }
}