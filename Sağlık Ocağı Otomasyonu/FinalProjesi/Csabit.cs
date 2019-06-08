using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class Csabit
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ELBT8SP9;Initial Catalog=SOHATS;Integrated Security=SSPI");

        public static void Baglan()
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {


            }

        }
        public static void Kapat()
        {
            baglanti.Close();
        }
    }
}
