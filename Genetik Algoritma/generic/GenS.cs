using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class GenS
    {     double gen;
    public GenS(double gen)
    {
        this.gen = gen;
    }
   

        public double Gen
        {
            get { return gen; }
            set { gen = value; }
        }
    }
}
