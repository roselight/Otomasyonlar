using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _153301013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            factory();

         
        }
        private void factory()
        {
            KumasFabrikasi f = new AFabrikasi();
            FabrikaClient c = new FabrikaClient(f);
            listBox1.Items.Add("A fabrikası üretimi "+f.CeketUret());
            KumasFabrikasi f1 = new BFabrikasi();
            FabrikaClient c1 = new FabrikaClient(f1);
            listBox1.Items.Add("B fabrikası üretimi "+f1.CeketUret());
            listBox1.Items.Add("----------------------------");
        }

    }
}
