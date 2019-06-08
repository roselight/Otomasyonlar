using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class KromozomS
    {
        List<GenS> genler = new List<GenS>();

        internal List<GenS> Genler
        {
            get { return genler; }
            set { genler = value; }
        }
        private double uygDegeri;

        public double UygDegeri
        {
            get { return uygDegeri; }
            set { uygDegeri = value; }
        }
        public KromozomS()
        {

        }
        public void genEkle(GenS gen)
        {
            genler.Add(gen);
        }

    }
}
