using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstovneDatoteke
{
    public partial class Form1 : Form
    {
        string imeDatoteke;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtVsebina.Text = "";
            openFileDialog1.Filter = "Tekstovne datoteke|*.txt|Vse datoteke|*.*";
            DialogResult a=   openFileDialog1.ShowDialog();
            if (a != DialogResult.OK)
                return;
            imeDatoteke = openFileDialog1.FileName;
            this.Text = imeDatoteke;
            //izpiši vsebino datoteke v txtVnos
            StreamReader sr = new StreamReader(imeDatoteke);
            string vrstica = sr.ReadLine();
            while (vrstica != null)
            {
                txtVsebina.Text += vrstica+Environment.NewLine;
                vrstica = sr.ReadLine();
            }
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(imeDatoteke);
            sw.Write(txtVsebina.Text);
            sw.Close(); //OBVEZNO
        }
    }
}
