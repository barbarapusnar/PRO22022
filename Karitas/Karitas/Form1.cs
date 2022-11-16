using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Karitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Darovi d = new Darovi();
            try
            {
                d.ZapŠt = int.Parse(txtZapŠt.Text);
            }
            catch (FormatException)
            {
                d.ZapŠt = 0;
            }
            d.Datum = dtpDatum.Value;
            d.Namen = txtNamen.Text;
            try
            {
                d.Znesek = double.Parse(txtZnesek.Text);
            }
            catch (FormatException)
            {
                d.Znesek =0;
            }
            d.Opombe = txtOpombe.Text;
            FileStream fs = new FileStream(Resource1.pot, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
            tsStatus.Text = "Zapisano";
            txtZapŠt.Text = "";
            txtZnesek.Text = "";
            txtOpombe.Text = "";
            txtNamen.Text = "";
            //txtZapŠt.Focus();

        }

        private void txtZapŠt_Enter(object sender, EventArgs e)
        {
            tsStatus.Text = "Pripravljen";
        }
    }
}
