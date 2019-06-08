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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            
            // Display a child form to show this is still an MDI application.
          
            Login lg = new Login();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.MdiParent = this;
            lg.Show();

           // menuStrip1.Enabled = false;
          ///  menustripItem1.Visible = false;
           


        }

        public void etkinlestir(bool a)
        {
            if(a==true)
            { 
                
                menuStrip1.Visible = true;
                menustripItem1.Enabled = true;
              
            }
            
        }

        private void polToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliTanit p = new PoliTanit();
            p.StartPosition = FormStartPosition.CenterScreen;
            p.MdiParent = this;
            p.Show();

        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullTanit k = new KullTanit();
            k.StartPosition = FormStartPosition.CenterScreen;
            k.MdiParent = this;
            k.Show();

        }

        private void hastaİşlemleriF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaProcess h = new HastaProcess();
            h.StartPosition = FormStartPosition.CenterScreen;
            h.MdiParent = this;
            h.Show();

        }

        private void raporlargeçiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapor r = new Rapor();
            r.StartPosition = FormStartPosition.CenterScreen;
            r.MdiParent = this;
            r.Show();
        }


      

    }
}
