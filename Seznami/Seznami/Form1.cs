using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seznami
{
    public partial class Form1 : Form
    {
        ArrayList seznam = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //dodaj v seznam vsebino txtVnos
            seznam.Add(txtVnos.Text);
            txtKonzola.Text = "Vnešen element v seznam " + txtVnos.Text;
            txtVnos.Text = "";
        }

        private void btnIzpiši_Click(object sender, EventArgs e)
        {
            string rezultat = "Elementi so" + Environment.NewLine;
            for (int k = 0; k < seznam.Count; k++)
            {
                rezultat += seznam[k] + Environment.NewLine;
            }
            txtKonzola.Text = rezultat;
        }

        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            //odstrani element iz seznama, ki ga vneseš v txtVnos
            seznam.Remove(txtVnos.Text);
            txtKonzola.Text = "Odstranjen element " + txtVnos.Text;
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
                txtKonzola.Text = "Prvi element je " + seznam[0].ToString();
            else
                txtKonzola.Text = "Seznam je prazen";
            
        }
    }
}
