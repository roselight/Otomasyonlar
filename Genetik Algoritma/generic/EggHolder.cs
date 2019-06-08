using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class EggHolder:FonkS
    {
        public EggHolder():base(-512,512,-968.6407,10)
        {

        }
        public override double hesapla(System.Collections.Generic.List<generic.GenS> x)
{
    double y = -(x[1].Gen + 47) * Math.Sin(Math.Sqrt(Math.Abs(x[1].Gen + x[0].Gen / 2 + 47))) - x[0].Gen * Math.Sin(Math.Sqrt(Math.Abs((x[0].Gen - (x[1].Gen + 47)))));
            return y;
}
    }
}
