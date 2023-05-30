using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public void search(string filename, char delim, string name)
    {
        int pos;
        StreamReader sr = new StreamReader(filename);
        string s;
        name = name.ToUpper();
        int i = 0;
        int con = -1;
        while ((s = sr.ReadLine()) != null)
        {
            string[] split = s.Split(delim);
            if (i != 0)
            {
                if (split[2] == name)
                {
                    pos = i;
                    MessageBox.Show($"Paese trovato in posizione {i}");
                    con = 0;
                }
            }
            i++;
        }
        if (con == -1)
        {
            MessageBox.Show("Nessun paese trovato");
        }
        sr.Close();
    }
    public void canc(string filename, char delim, string x, string reg)
    {
        StreamReader sr = new StreamReader(filename);
        StreamWriter sw = new StreamWriter(@"temp.csv");
        int i = 0;
        string s;
        while ((s = sr.ReadLine()) != null)
        {
            if (i != 0)
            {
                string[] split = s.Split(delim);
                if (split[2] == x && split[1] == reg)
                {
                    split[10] = "false";
                    for (int j = 0; j < split.Length; j++)
                    {
                        if (j == split.Length - 1) s = split[j];
                        else s = split[j] + delim;
                    }
                }
                sw.WriteLine(s);
            }
            i++;
        }
        sr.Close();
        sw.Close();
        File.Replace(@"temp", filename, @"backup.csv");
        File.Delete(@"backup.csv");
    }
}
}
}

