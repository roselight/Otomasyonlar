using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    abstract class FonkS
    {
        int genSayisi;

        public int GenSayisi
        {
            get { return genSayisi; }
            set { genSayisi = value; }
        }
        double altSinir, ustSinir, minDeger;

        public double MinDeger
        {
            get { return minDeger; }
            set { minDeger = value; }
        }

        public double UstSinir
        {
            get { return ustSinir; }
            set { ustSinir = value; }
        }

        public double AltSinir
        {
            get { return altSinir; }
            set { altSinir = value; }
        }
        public FonkS(double altSinir, double ustSinir,double minDeger,int genSayisi)
        {
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            this.minDeger = minDeger;
            this.genSayisi = genSayisi;

        }
        abstract public double hesapla(List<GenS> x);
       
    }
}
