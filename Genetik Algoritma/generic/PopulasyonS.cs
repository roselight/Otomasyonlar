using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class PopulasyonS
    {
        List<KromozomS> kromozomlistesi = new List<KromozomS>();

        internal List<KromozomS> Kromozomlistesi
        {
            get { return kromozomlistesi; }
            set { kromozomlistesi = value; }
        }
        public PopulasyonS()
        {

        }
        public void kromozomEkle(KromozomS kromozom)
        {
            kromozomlistesi.Add(kromozom);

        }
       
    }
}
