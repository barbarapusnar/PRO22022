using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraKarte
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Kup k1 = new Kup();
        Kup k2;
        public Form1()
        {
            InitializeComponent();
            //10 naključnih kart dodaj v neko listo tipa karta
            List<Karta> nak = new List<Karta>();
            //random karte
            k2 = new Kup(nak);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
