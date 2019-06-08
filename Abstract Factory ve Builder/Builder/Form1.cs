using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------B ÜRETİCİSİ------------------");
            CantaCreator c = new CantaCreator(new BBuilder());
            c.CreateCanta();
            Canta canta = c.GetCanta();
            ArrayList arr = new ArrayList();
            arr = canta.Goster();
            foreach (var item in arr)
            {
                listBox1.Items.Add(item);
            }
    
            listBox1.Items.Add("------------------A ÜRETİCİSİ---------------------");
            c = new CantaCreator(new ABuilder());
            c.CreateCanta();
             canta = c.GetCanta();
            arr = canta.Goster();
            foreach (var item in arr)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
