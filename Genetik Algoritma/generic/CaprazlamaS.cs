using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class CaprazlamaS
    {
        List<KromozomS> minnaklar = new List<KromozomS>();
        Random rnd = new Random();
        public List<KromozomS> caprazla(KromozomS ilkbry,KromozomS ikincibry,double caprazlamaOran)
        {
            minnaklar.Clear();
            int rastgele = rnd.Next(0,ilkbry.Genler.Count);
            for (int i = 0; i < 2; i++)
            {
                KromozomS kromozom=new KromozomS();
                for (int j = 0; j < ilkbry.Genler.Count; j++)
			{
			 if(i==0)
                {
                    if (rastgele == j)
                        kromozom.genEkle(ikincibry.Genler[rastgele]);
                    else
                        kromozom.genEkle(ilkbry.Genler[j]);
                }
                    else
             {
                 if (rastgele == j)
                     kromozom.genEkle(ilkbry.Genler[rastgele]);
                 else
                     kromozom.genEkle(ikincibry.Genler[j]);
             }
			}
                minnaklar.Add(kromozom); 
            }
            return minnaklar;
        }
    }
}
