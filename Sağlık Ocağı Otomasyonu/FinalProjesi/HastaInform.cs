using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjesi
{
    public partial class HastaInform : Form
    {
        SqlHasta ws = new SqlHasta();
        HastaProperty h = new HastaProperty();

        public HastaInform(int deger)
        {  
            int d;
            d = deger;

            InitializeComponent();
            if(deger!=-1)
            {
              
                ws.HastaBilgileriCek(h,deger);   degerler();}
            else
               txtdosyano.Text=ws.DosyaNoCek().ToString();
        }

        private void HastaInform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            try
            { 
                
                if(txtTC.Text=="")
            {
                throw new HataBosAlan();
            }
                h.Ad = txtadi.Text;
                h.Soyad = txtSoyadi.Text;
                h.Adres = txtAdres.Text;
                h.Anneadi = txtAnneAdi.Text;
                h.Babaadi = txtBabaAdi.Text;
                h.Cinsiyet = cmbCinsiyet.Text;
                h.Dogumtarihi = DtDogumTarihi.Text;
                h.Dogumyeri = txtDogumyeri.Text;
                h.Dosyano = txtdosyano.Text;
                h.Kangrubu = cmbKangrubu.Text;
                h.Kurumadi = txtKurumAdi.Text;
                h.Kurumsicilno = txtKurumSicilNo.Text;
                h.Medenihal = cmbMedeniHal.Text;
                h.Tckimlikno = txtTC.Text;
                h.Tel = txttelno.Text;
                h.Yakınkurumadi = txtYakinKurumAdi.Text;
                h.Yakinkurumsicilno = txtyakinkuruSicilNO.Text;
                h.Yakintel = txtYakinTel.Text;
                ws.HastaEkle(h);
                label12.Text = "İşlem Başarılı";
            }
            catch (HataBosAlan h)
            {
                MessageBox.Show(h.Message);
            }
               
            
         
        }
        private void degerler()
        {
           txtadi.Text=h.Ad;                 
           txtSoyadi.Text=h.Soyad ;             
           txtAdres.Text=h.Adres ;             
           txtAnneAdi.Text=h.Anneadi ;           
           txtBabaAdi.Text=h.Babaadi;            
           cmbCinsiyet.Text=h.Cinsiyet;           
           DtDogumTarihi.Text=h.Dogumtarihi;        
           txtDogumyeri.Text=h.Dogumyeri ;         
           txtdosyano.Text=h.Dosyano ;           
           cmbKangrubu.Text=h.Kangrubu ;          
           txtKurumAdi.Text=h.Kurumadi ;          
           txtKurumSicilNo.Text=h.Kurumsicilno ;      
           cmbMedeniHal.Text=h.Medenihal ;         
           txtTC.Text=h.Tckimlikno  ;       
           txttelno.Text=h.Tel   ;             
           txtYakinKurumAdi.Text=h.Yakınkurumadi    ;  
           txtyakinkuruSicilNO.Text=h.Yakinkurumsicilno  ;
           txtYakinTel.Text = h.Yakintel;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = item as ComboBox;
                    cmb.Text = String.Empty;
                }
                else if (item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    chk.Checked = false;
                }
                else if (item is RichTextBox)
                {
                    RichTextBox rich = item as RichTextBox;
                    rich.Clear();

                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = item as DateTimePicker;
                    dt.Text = String.Empty;
                }
                
                txtdosyano.Text =ws.DosyaNoCek().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((int)e.KeyChar >=65 && (int)e.KeyChar <=90)
            {
                e.Handled = false;//büyük harfleri yazdır
            }
            else if ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122)
            {
                e.Handled = false;//küçük harfler
            }
            else if((int)e.KeyChar==46)
            {
                e.Handled = false;
            }
            else if(e.KeyChar==(int)Keys.EraseEof)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled=true;  //bunlar dışında hiçbiri
            }
        }

        private void txtYakinTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (int)Keys.EraseEof)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
