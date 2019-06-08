using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class hata:ApplicationException
    {
        int sayi;

        public int Sayi
        {
            get { return sayi; }
            set { sayi = value; }
        }
        public hata(int sayi)
        {
            this.sayi = sayi;
        }
        public override string ToString()
        {
            return "Negatif ";
        }
    }
}
