using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface CantaBuilder
    {
        void SetFermuar();
        void SetKumasTipi();
        void KumasRengi();
        void SetAksesuar();
        Canta GetCanta();
    }

    public class ABuilder:CantaBuilder
    {
        Canta c = new Canta();
        public void SetFermuar()
        {
            c.Fermuar = "Gizli Fermuar";
        }
        public void SetKumasTipi()
        {
            c.KumasTipi = "Deri";

        }
        public void KumasRengi()
        {
            c.KumasRengi = "Kahverengi";
        }
        public void SetAksesuar()
        {
            c.Aksesuar.Add("Gümüş Toka");
            c.Aksesuar.Add("Püskül");
        }
        public Canta GetCanta()
        {
            return c;
        }
    }
    public class BBuilder : CantaBuilder
    {
        Canta c = new Canta();
        public void SetFermuar()
        {
            c.Fermuar = "Kalın Fermuar";
        }
        public void SetKumasTipi()
        {
            c.KumasTipi = "Koton";

        }
        public void KumasRengi()
        {
            c.KumasRengi = "Lacivert";
        }
        public void SetAksesuar()
        {
            c.Aksesuar.Add("Renkli Boncuk");
            c.Aksesuar.Add("Çiçek Aplike");
        }
        public Canta GetCanta()
        {
            return c;
        }
    }

    public class Canta
    {
        public string Fermuar { get; set; }
        public string KumasTipi { get; set; }
        public string KumasRengi { get; set; }
        public List<string> Aksesuar { get; set; }
        public Canta()
        {
            Aksesuar = new List<string>();
        }
        public ArrayList Goster()
        {
            ArrayList ar = new ArrayList();
            ar.Add("Fermuar Tipi: "+Fermuar);
            ar.Add("Kumaş Rengi: " + KumasRengi);
            ar.Add("Kumaş Tipi: " + KumasTipi);
            foreach (var item in Aksesuar)
            {
                ar.Add("Aksesuar Çeşidi: " + item);
                
            }
            return ar;

        }
       
    }
     
    public class CantaCreator
    {
        private readonly CantaBuilder objbuilder;
        public CantaCreator(CantaBuilder builder)
        {
            objbuilder=builder;
        }
        public void CreateCanta()
        {
            objbuilder.KumasRengi();
            objbuilder.SetAksesuar();
            objbuilder.SetFermuar();
            objbuilder.SetKumasTipi();
            
        }
        public Canta GetCanta()
        {
            return objbuilder.GetCanta();
        }

    }
   

}
