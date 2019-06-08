using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    abstract class BireySec
    {
        public static BireySec yontem  ()
        {
            return new TurnuvaSecimi();
        }

        abstract public KromozomS birey_sec(List<KromozomS> list);

    }
}
