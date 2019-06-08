using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double globalmin = (double)ngmin.Value;
            int parcaciksayisi = (int)nparcacik.Value;
            int jenerasyon = (int)njen.Value;
            int c1 = (int)nc1.Value;
            int c2= (int)nc2.Value;
            pso ps = new pso(-1.04802,2,parcaciksayisi,5,-5,jenerasyon,c1,c2);
         
            for (int i = 0; i < 10; i++)
            {listBox1.Items.Add("x1 x2");
                for (int j = 0; j < 2; j++)
                {
                     
                     listBox1.Items.Add(ps.parcaciklar[i].Veri[j]);
                     
                }listBox1.Items.Add("--------------------");
         
            }
        
            label6.Text = ps.parcaciklar[ps.enIyiIndex()].Veri[0].ToString();
            label7.Text = ps.parcaciklar[ps.enIyiIndex()].Veri[1].ToString();
            label8.Text = ps.hesapla(ps.parcaciklar[ps.enIyiIndex()].Veri[0], ps.parcaciklar[ps.enIyiIndex()].Veri[1]).ToString();

         


        }

        private void label6_Click(object sender, EventArgs e)
        {

        } 
        
    
        
     
   
    }
}
