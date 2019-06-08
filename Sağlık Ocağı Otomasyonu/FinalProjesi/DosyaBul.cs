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
    public partial class DosyaBul : Form
    {
        public DosyaBul()
        {
            InitializeComponent();
            cmbkriter.SelectedIndex = 0;
        }
        public void kontrol()
        {
            HastaProperty h = new HastaProperty();
           
            h.Tckimlikno= txtveri1.Text;
            switch (cmbkriter.SelectedIndex)
            {
                case 0: // hasta ad soyad
                    {

                        h.Ad = txtveri1.Text; h.Secim = 0;
                        if (checkand.Checked == true)
                        {
                            h.Soyad = txtveri2.Text;
                            h.Secim = 10;
                        }
                        break;
                    }
                case 1:
                    {
                        h.Tckimlikno = txtveri1.Text;
                        h.Secim = 1;
                        break;
                    }
                case 2:
                    {
                        h.Kurumsicilno = txtveri1.Text;
                        h.Secim = 2;
                        break;
                    }
                case 3:
                    {
                        h.Dosyano = txtveri1.Text;
                        h.Secim = 3;
                        break;
                    }
            }
            SqlHasta ws = new SqlHasta();
            datagrid.DataSource= ws.Bul(h);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        private void cmbkriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbkriter.SelectedIndex!=0)
            {
                txtveri1.Size = new Size(485,22);
                txtveri2.Visible = false;
                checkand.Visible=false;
            }
            else if(cmbkriter.SelectedIndex==0)
            {

                txtveri1.Size = new Size(207, 22);
                txtveri2.Visible = true;
                checkand.Visible = true;
            }
        }
    }
}
