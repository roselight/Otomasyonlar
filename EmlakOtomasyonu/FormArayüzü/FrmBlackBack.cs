using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FormArayüzü
{
    public partial class FrmBlackBack : DevExpress.XtraEditors.XtraForm
    {
   
      //  private KitapSatýnAl ftemp1;

        public FrmBlackBack(XtraForm Ftemp)
        {
            this.components = null;
            this.opastiy = 70;
            this.bColor = Color.Black;
            this.InitializeComponent();
            this.Ftemp2 = Ftemp;
        }
        public FrmBlackBack(XtraForm Ftemp, Color color)
        {
            this.components = null;
            this.opastiy = 70;
            this.bColor = Color.Black;
            this.InitializeComponent();
            this.Ftemp2 = Ftemp;
            this.bColor = color;
        }
        public FrmBlackBack(XtraForm Ftemp, int Opastiy)
        {
            this.components = null;
            this.opastiy = 70;
            this.bColor = Color.Black;
            this.InitializeComponent();
            this.opastiy = Opastiy;
            this.Ftemp2 = Ftemp;
        }
        public FrmBlackBack(XtraForm Ftemp, int Opastiy, Color color)
        {
            this.components = null;
            this.opastiy = 70;
            this.bColor = Color.Black;
            this.InitializeComponent();
            this.opastiy = Opastiy;
            this.bColor = color;
            this.Ftemp2 = Ftemp;
        }

      

    
        private void FrmBlackBack_Shown(object sender, EventArgs e)
        {
            double num = ((double)this.opastiy) / 100.0;
            this.BackColor = this.bColor;
            base.Opacity = num;
            TopMost = false;
            this.Ftemp2.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            this.Ftemp2.ShowDialog();
            base.Close();
        }
    }
}