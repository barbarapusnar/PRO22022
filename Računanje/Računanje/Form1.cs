using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Računanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double re1 =double.Parse( textBox1.Text);
            double im1 = double.Parse(textBox2.Text);
            Kompleksno a = new Kompleksno(re1,im1);
            Kompleksno b = new Kompleksno(re2, im2);
            
            //izpiši v label spodaj
            labRezultat.Text = (a+b).ToString();
        }
    }
}
