using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjesi
{
    public partial class Taburcu : Form
    { 
  
      HastaProperty h = new HastaProperty();
      SqlHasta ws = new SqlHasta();
        public Taburcu()
        {
           
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void kaydet()
        {
            h.Dosyano = txtdosyano.Text;
            h.Sevktarihi = dtsevktarihi.Text;
            h.Cikistarihi = dtcikis.Text;
            h.Odeme = cmbodeme.Text;
            h.Toplamtutar = txttoplamtutar.Text;
            ws.hastaCikisTarihi(h);

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kaydet();
        }


    }
}
