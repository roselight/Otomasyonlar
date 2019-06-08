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
    public partial class Login : Form
    {
        SqlKullanici ws = new SqlKullanici();
        KullaniciProperty k = new KullaniciProperty();

        public Login()
        {
            InitializeComponent();
             
        }
      
      
        private void GirisYap()
        {
           
            if (txtusername.Text == ""&& txtsifre.Text == "")
            {
                throw new HataBosAlan(); 
            }

            k.Username = txtusername.Text;
            k.Sifre = txtsifre.Text;
            bool a;      a=ws.kulllanicigiris(k);

           if(a==true)
           {
              
               AnaForm ana = new AnaForm();
               ana.etkinlestir(a); this.Close();
           }
           else
           {
            MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre"); 

           }
           
           
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                GirisYap();
              
            }
            catch (HataBosAlan h)
            {
                MessageBox.Show(h.Message);
            }
          
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
