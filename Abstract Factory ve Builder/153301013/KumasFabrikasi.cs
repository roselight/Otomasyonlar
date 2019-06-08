using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301013
{
    abstract class KumasFabrikasi
    {
        abstract public SoyutCeket CeketUret();
        abstract public SoyutGomlek GomlekUret();
    }

    class AFabrikasi:KumasFabrikasi
    {
        public override SoyutCeket CeketUret()
        {
            return new KotonCeket(); 
        }
        public override SoyutGomlek GomlekUret()
        {
            return new KotonGomlek();
        }

    }
    class BFabrikasi:KumasFabrikasi
    {
        public override SoyutCeket CeketUret()
        {
            return new DeriCeket();
        }
        public override SoyutGomlek GomlekUret()
        {
            return new KotonGomlek();
        }
    }
    abstract class SoyutCeket
    {
        abstract public string Name();
    }

    abstract class SoyutGomlek
    {
        abstract public string Name();
    }
    class DeriCeket:SoyutCeket
    {
        public override string Name()
        {
            return "Deri ceket";
        }
    }
    class KotonGomlek:SoyutGomlek
    {
        public override string Name()
        {
            return "Koton Gomlek";
        }
    }
    class KotonCeket:SoyutCeket
    {
        public override string Name()
        {
            return "Koton Ceket";
        }
    }
    class FabrikaClient
    {
        private SoyutCeket Ceket;
        private SoyutGomlek Gomlek;
        public FabrikaClient(KumasFabrikasi fabrika)
        {
            Ceket = fabrika.CeketUret();
            Gomlek = fabrika.GomlekUret();
        }
    }


}
