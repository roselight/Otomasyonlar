using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pso
{
    class pso
    {
        Random rnd;

         public List<parcacik> parcaciklar=null;
        private int deger,parcaciksayisi,xmax,xmin,epoch,c1,c2;
        private double gmin;
        public pso(double minglobal,int deg,int psay, int max, int min,int e,int _c1,int _c2)
        {
            c1 = _c1; c2 = _c2;
            gmin = minglobal;

            deger = deg;
            parcaciksayisi = psay;
            xmax = max;
            xmin = min;
            epoch = e;
            double sonuc;
            parcacik gecici = null;
            rnd = new Random();
            parcaciklar=new List<parcacik>();
            for (int i = 0; i < parcaciksayisi; i++)
            {
                sonuc = 0;
                gecici = new parcacik(deger);
                for (int j = 0; j < deger; j++)
                {
                    gecici.Veri[j] = rnd.NextDouble() * (xmax - xmin) + xmin;

                }
                sonuc = hesapla(gecici.Veri[0], gecici.Veri[1]);
                gecici.Sonuc = sonuc;
                gecici.Pbest = sonuc;
                parcaciklar.Add(gecici);
            }

        }
        public double hesapla(double x1,double x2)
        {
            double fonk = 4 * Math.Pow(x1, 2) - 2.1 * Math.Pow(x1, 4) + (1 / 3) * Math.Pow(x1, 6) + x1 * x2 - 4 * Math.Pow(x2, 2) + 4 * Math.Pow(x2, 4);
            return fonk;
        }
        int gbestindex = 0;
        int gbestgecici = 0;

        public void optimizasyon()
        {

            bool bulundumu = false;
            int epochsayac = 0;
            while ((!bulundumu) && (epochsayac<epoch) )
            {
                for (int i = 0; i < parcaciksayisi; i++)
                {
                        if(parcaciklar[i].Sonuc==gmin)
                        {
                            bulundumu = true;
                            break;
                        }
                        
                }
                if (!bulundumu)
                {
                    gbestgecici = enIyiIndex();
                    if (Math.Abs(gmin-parcaciklar[gbestgecici].Sonuc)<Math.Abs(gmin-parcaciklar[gbestindex].Sonuc))
                    {
                        gbestindex = gbestgecici;
                    }
                    hizguncelle(gbestindex);
                    degerguncelle(gbestindex);
                    epochsayac++;
                }
                
            }
           
        }

        public int enIyiIndex()
        {
            int index = 0;
            for (int i = 0; i < parcaciksayisi; i++)
            {
                if(Math.Abs(gmin-parcaciklar[i].Sonuc)<Math.Abs(gmin-parcaciklar[index].Sonuc))
                {
                    index = i;

                }

                
            }
            return index;
        }
        public void hizguncelle(int sayi)
        {


            double suanki = 0;
            double eniyi = 0;
            double gecici = 0;
            eniyi = parcaciklar[sayi].Sonuc;
            for (int i = 0; i < parcaciksayisi; i++)
            {
                for (int j = 0; j <deger ; j++)
                {
                    suanki = parcaciklar[i].Veri[j];
                    gecici = (parcaciklar[i].Hiz[j] + c1 * rnd.NextDouble() * (parcaciklar[i].Pbest - suanki) + c2 * rnd.NextDouble() * (eniyi - suanki));
                    parcaciklar[i].Hiz[j] = gecici;
                }
            }
            
        }
        public void degerguncelle(int gbestindex)
        {
            double gecicitoplam=0;
            for (int i = 0; i < parcaciksayisi; i++)
            {
                for (int j = 0; j < deger; j++)
                {
                      if(parcaciklar[i].Veri[j]!=parcaciklar[gbestindex].Veri[j])
                      {
                          double dene = parcaciklar[i].Veri[j] + parcaciklar[i].Hiz[j];
                          if (dene > xmax)
                          {
                              parcaciklar[i].Veri[j] = xmax;
                          }
                          else if (dene < xmin)
                          {
                              parcaciklar[i].Veri[j] = xmin;
                          }

                          else
                              parcaciklar[i].Veri[j] = dene;
                      
                   
                      }

                }
                parcaciklar[i].Sonuc = hesapla(parcaciklar[i].Veri[0], parcaciklar[i].Veri[1]);
                gecicitoplam = parcaciklar[i].Sonuc;
                if(Math.Abs(gmin-gecicitoplam)<parcaciklar[i].Pbest)
                {
                    parcaciklar[i].Pbest = gecicitoplam;
                }
            }
            
        }

       

    }
}
