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
    public partial class KullTanit : Form
    {
        public KullTanit()
        {
            InitializeComponent();
        }
   
        private void cmbPoliklinikad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                Kullanici k = new Kullanici();
                k.MdiParent = Form.ActiveForm;
                k.StartPosition = FormStartPosition.CenterScreen;
                k.Show();
            }
        }

        private void btnyenikullaniciekle_Click(object sender, EventArgs e)
        {
            this.Close();
            Kullanici k = new Kullanici();
            k.MdiParent = Form.ActiveForm;
            k.StartPosition = FormStartPosition.CenterScreen;
            k.Show();
           
        }
    }
}
