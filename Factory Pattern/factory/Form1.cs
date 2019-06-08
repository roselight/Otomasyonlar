using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapla();
        }
        private void hesapla()
        { 
            int a = Convert.ToInt32(textBox1.Text);

            label7.Text = Factory.Get(a).getkumasadi() + " Fiyatı: " + Factory.Get(a).getkumasfiyat() + " TL";

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                hesapla();
        }
    }

   
}
