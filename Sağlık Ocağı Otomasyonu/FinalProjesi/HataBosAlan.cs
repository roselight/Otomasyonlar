using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    class HataBosAlan:Exception
    {
        public HataBosAlan():base("İşaretli Alanlar Boş Bırakılamaz.")

        { }

    }
}
