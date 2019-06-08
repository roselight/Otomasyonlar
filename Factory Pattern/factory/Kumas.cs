using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
     public interface Kumas
    {
        double getkumasfiyat();
        string getkumasadi();

    }
    public class Ipek : Kumas
    {
        private double _fiyat;
        public Ipek(double fiyat)
        {
            _fiyat = fiyat;
        }
        public string getkumasadi()
        {
            return "İpek Kumaş";
        }
        public double getkumasfiyat()
        {
            return _fiyat;
        }
    }
    public class Kadife:Kumas
    {
        private double _fiyat;
        public Kadife(double fiyat)
        {
            _fiyat = fiyat;
        }
        public string getkumasadi()
        {
            return "Kadife Kumaş";
        }
        public double getkumasfiyat()
        {
            return _fiyat;
        }
    }
    public class Saten:Kumas
        {
        private double _fiyat;
        public Saten(double fiyat)
        {
            _fiyat = fiyat;
        }
        public string getkumasadi()
        {
            return "Saten Kumaş";
        }
        public double getkumasfiyat()
        {
            return _fiyat;
        }
    }
        public class Pamuklu:Kumas
            {
            private double _fiyat;
            public Pamuklu(double fiyat)
        {
            _fiyat = fiyat;
        }
        public string getkumasadi()
        {
            return "Pamuklu Kumaş";
        }
        public double getkumasfiyat()
        {
            return _fiyat;
        }
    }
           
    public class Koton :Kumas
    {
        private double _fiyat;
        public Koton(double fiyat)
        {
            _fiyat = fiyat;
        }
        public string getkumasadi()
        {
            return "Koton Kumaş";
        }
        public double getkumasfiyat()
        {
            return _fiyat;
        }
    }
    static class Factory
    {
        public static Kumas Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Ipek(30.90);
                case 1:
                    return new Kadife(15.50);
                case 2:
                    return new Saten(19.40);
                case 3:
                    return new Pamuklu(7.85);
                case 4:
                    return new Koton(9.35);
                default:
                    return null;

            }
        }
    }
}

