using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAHINO_CSV_FINALE
{
    public partial class Form1 : Form
    {
        funzioni f;
        string filename;
        string filename1;
        char delim;
        public int dim;

        public Form1()
        {
            InitializeComponent();
            f = new funzioni();
            filename = @"Cahino1.csv";
            filename1 = @"Cahino.csv";
            dim = 0;
            delim = ';';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il numero di campi presenti nel file CSV è: " + f.col(filename, delim));
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
