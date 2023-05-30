using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAHINO_CSV_FINALE
{
    public class funzioni
    {
        public void RandeLog(string filename, string filename1, char delim)
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter(filename, append: false);
            StreamReader sr = new StreamReader(filename1);
            string s = sr.ReadLine();
            int i = 0;
            while (s != null)
            {
                if (i == 0)
                {
                    sw.WriteLine(s + delim + "MioValore" + delim + "Cancellazione logica");
                }
                else
                {
                    sw.WriteLine(s + delim + r.Next(10, 20) + delim + "true");
                }
                s = sr.ReadLine();
                i++;
            }
            sr.Close();
            sw.Close();
        }
    }
}
