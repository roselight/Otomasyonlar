using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjesi 
{
    public partial class HastaProcess : Form
    {
        SqlHasta ws = new SqlHasta();
        HastaProperty h = new HastaProperty();
        public HastaProcess()
        {
            InitializeComponent();
        }

        private void HastaProcess_Load(object sender, EventArgs e)
        {

        }


        private void sevkekle()
        {
            h.Dosyano = txtdosyano.Text;
            h.Sevktarihi = dtsevk.Text;
            h.Poliklik = cmbpolik.Text;
            h.Yapilanislem = cmbyapilanislem.Text;
            h.Drkodu = cmbdrkodu.Text;
            h.Miktar = numericmiktar.Value.ToString();
            h.Birimfiyat = txtbirimfiyat.Text;
            h.Sira = txtsirano.Text;
            h.Toplamtutar = label14.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DosyaBul db = new DosyaBul();
            db.StartPosition = FormStartPosition.CenterScreen;
            db.MdiParent = Form.ActiveForm;
            db.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Taburcu t = new Taburcu();
            t.StartPosition = FormStartPosition.CenterScreen;
            t.MdiParent = Form.ActiveForm;
            t.Show();
        }

        private void txtdosyano_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SystemSounds.Beep.Play();  
                h.Dosyano = txtdosyano.Text;
               
                ws.DosyaBilgisiCek(h);
                txtHastaAdi.Text = h.Ad;
                txthastaSoyadi.Text = h.Soyad;
                txtKurumAdi.Text=h.Kurumadi;
                dtsevk.Text = h.Sevktarihi;
                
            }
        }

   
        
        private void button2_Click(object sender, EventArgs e)
        {
           h.Sevktarihi = cmbOncekislemler.Text;
           h.Dosyano = txtdosyano.Text;
            dataGridView1.DataSource = ws.OncekiIslemGit(h);
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {

            try
            {
                hastabilgileriformuac();
            }
            catch(HataBosAlan  h)
            {
                MessageBox.Show(h.Message);
            }
        }


        private void btnYeni_Click(object sender, EventArgs e)
        {
            int deger1 = -1;
            HastaInform hi = new HastaInform(deger1);
            hi.StartPosition = FormStartPosition.CenterScreen;
            hi.MdiParent = Form.ActiveForm;
            hi.Show();
        }
        private void hastabilgileriformuac()
        {
            if (txtdosyano.Text == "")
            {
                throw new HataBosAlan();
            }
            else
            {
                int deger1 = Convert.ToInt32(txtdosyano.Text);
                HastaInform hi = new HastaInform(deger1);
                hi.StartPosition = FormStartPosition.CenterScreen;
                hi.MdiParent = Form.ActiveForm;
                hi.Show();
            }
        }

        private void btnbaskionizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnyazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            e.Graphics.DrawString("SAĞLIK OCAĞI", myFont, sbrush, 415, 120, sf);
            e.Graphics.DrawString("HASTA SEVK İŞLEMLERİ", myFont, sbrush, 415, 200, sf);
            e.Graphics.DrawString(txtHastaAdi.Text + " " + txthastaSoyadi.Text, myFont, sbrush, 415, 280, sf);
            e.Graphics.DrawLine(myPen, 0, 320, 0, 320);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Poliklinik", myFont, sbrush, 120, 328);
            e.Graphics.DrawString("Sıra", myFont, sbrush, 255, 328);
            e.Graphics.DrawString("Saat", myFont, sbrush, 320, 328);
            e.Graphics.DrawString("Yapılan İşlem", myFont, sbrush, 375, 328);
            e.Graphics.DrawString("Dr.Kodu", myFont, sbrush, 520, 328);
            e.Graphics.DrawString("Miktar", myFont, sbrush, 600, 328);
            e.Graphics.DrawString("Birim Fiyatı", myFont, sbrush, 670, 328);
            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            decimal gTotal = 0;
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null) break;
                e.Graphics.DrawString(row.Cells[0].Value.ToString(), myFont, sbrush, 195, y, myStringFormat);
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), myFont, sbrush, 280, y, myStringFormat);
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), myFont, sbrush, 360, y, myStringFormat);
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), myFont, sbrush, 445, y, myStringFormat);
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), myFont, sbrush, 560, y, myStringFormat);
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), myFont, sbrush, 655, y, myStringFormat);
                e.Graphics.DrawString(row.Cells[6].Value.ToString(), myFont, sbrush, 755, y, myStringFormat);
                i++;
                y += 20;

            }
            if (label14.Text == "") gTotal = 0;
            else gTotal = decimal.Parse(label14.Text);
            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            e.Graphics.DrawString("Toplam Tutar:", myFont, sbrush, 650, y + 10, myStringFormat);
            e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 755, y + 10, myStringFormat);


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sevkekle();
            ws.SevkEkle(h);
        }
    }
}
