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
    public partial class PoliTanit : Form
    {
        public PoliTanit()
        {
            InitializeComponent();
        }

        private void cmbPoliklinikad_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.Close();
                Poliklinik pol = new Poliklinik();
                pol.MdiParent = Form.ActiveForm;
                pol.StartPosition = FormStartPosition.CenterScreen;
                pol.Show();
            }
        }

        private void PoliTanit_Load(object sender, EventArgs e)
        {

        }

    }
}
