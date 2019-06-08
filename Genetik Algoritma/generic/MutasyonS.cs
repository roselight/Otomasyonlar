using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    abstract class MutasyonS
    {
        public static MutasyonS mutasyon_yontem()
        {
            return new ToplamaMutasyon();
        }

        abstract public List<KromozomS> mutasyon_yap(List<KromozomS> list, double mutasyonOrani, double altsinir, double ustsinir);

    }
    class ToplamaMutasyon : MutasyonS
    {


        public override List<KromozomS> mutasyon_yap(List<KromozomS> liste, double mutasyonOrani, double altSinir, double ustSinir)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = 0; j < liste[i].Genler.Count; j++)
                {
                    liste[i].Genler[j].Gen = liste[i].Genler[j].Gen + mutasyonOrani;
                    if (liste[i].Genler[j].Gen > ustSinir)
                        liste[i].Genler[j].Gen = ustSinir;
                    if (liste[i].Genler[j].Gen < altSinir)
                        liste[i].Genler[j].Gen = -altSinir;
                }
            }
            return liste;
        }
    }
}
