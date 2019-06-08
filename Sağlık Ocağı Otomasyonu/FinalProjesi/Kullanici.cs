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
    public partial class Kullanici : Form
    {
        SqlKullanici ws = new SqlKullanici();
        KullaniciProperty k = new KullaniciProperty();

        public Kullanici()
        {
            InitializeComponent();
            txtKullaniciKodu.Text =ws.KullaniciKoduCek().ToString();
            
        }
     
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            k.Ad = txtAd.Text;
            k.Adres = txtadres.Text;
            k.Annead = txtAnneAd.Text;
            k.Babaad = txtBabaAd.Text;
            k.Ceptel = txtGSM.Text;
            k.Cinsiyet = cmbCinsiyet.Text;
            k.Dogumtarihi = DtDogumTarihi.Text;
            k.Dogumyeri = txtDogumYeri.Text;
            k.Evtel = txtTel.Text;
            k.Isebaslama = DtIseBaslama.Text;
            k.Kangrubu = cmbKanGrubu.Text;
            k.Kodu = txtKullaniciKodu.Text;
            k.Maas = txtMaas.Text;
            k.Medenihal = cmbMedeniHal.Text;
            k.Sifre = txtKullaniciSifre.Text;
            k.Soyad = txtSoyad.Text;
            k.Tckimlikno = txtTc.Text;
            k.Unvan = cmbUnvan.Text;
            k.Username = txtKullaniciAdi.Text;
          //  k.Yetki = checkYetkiliKullanici.Checked;
            ws.KullaniciEkle(k);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                else if (item is ComboBox)
                { ComboBox cmb = item as ComboBox;
                cmb.Text = String.Empty;
                }
                else if(item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    chk.Checked = false;
                }
                else if(item is RichTextBox)
                {
                    RichTextBox rich = item as RichTextBox;
                    rich.Clear();

                }
                else if(item is DateTimePicker)
                {
                    DateTimePicker dt = item as DateTimePicker;
                    dt.Text = String.Empty;
                }
                txtKullaniciKodu.Text = ws.KullaniciKoduCek().ToString();
            }}
           

            private void btnCikis_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void Kullanici_Load(object sender, EventArgs e)
            {

            }

            private void btnSil_Click(object sender, EventArgs e)
            {

            }
        }
    }

