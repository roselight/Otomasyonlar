using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pso
{
    class parcacik
    {
        private double sonuc;

        public double Sonuc
        {
            get { return sonuc; }
            set { sonuc = value; }
        }
        private double[] veri, hiz;

        public double[] Veri
        {
            get { return veri; }
            set { veri = value; }
        }

        public double[] Hiz
        {
            get { return hiz; }
            set { hiz = value; }
        }
        private double  pbest;

        public double Pbest
        {
            get { return pbest; }
            set { pbest = value; }
        }

       

        
        public parcacik(int deger)
        {
            veri = new double[deger];
            pbest = 0;
            hiz = new double[deger];
        }

       
        

    }
}
