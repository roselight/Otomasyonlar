using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class TurnuvaSecimi:BireySec
    {
        Random rnd = new Random();
        public override KromozomS birey_sec(List<KromozomS> list)
        {
            int sayi1 = rnd.Next(0, list.Count);
            int sayi2 = rnd.Next(0, list.Count);
            if (sayi2 <= sayi1)
                Form1.index = sayi2;
            else
                Form1.index = sayi1;

            return list[Form1.index];
        }
    }
}
