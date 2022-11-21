using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karitas
{
    public partial class Tiskanje : Form
    {
        List<Darovi> spremembe = new List<Darovi>();
        List<Darovi> filter = new List<Darovi>();
        private double znesekVDobro = 0;
        private double znesekVBreme = 0;
        private double saldo = 0;
        private Font printFont= new Font("Arial", 10);
        public Tiskanje()
        {
            InitializeComponent();
        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0; // število vrstic na stran
            float yPos = 0; // y pozicija
            int count = 0; // število vseh izpisanih vrstic
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null; // vrstica za izpis
            int štVrstice = 0;
            RačunajVsote(); // metoda za izračun vsot
            // število vrstic na eno stran, zapisov je lahko veliko
            linesPerPage = ev.MarginBounds.Height /
            printFont.GetHeight(ev.Graphics);
            //prva vrstica – naslov dokumenta
            line = "Izpis vseh darov in izdatkov za Karitas";
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris slike
            // Bitmap bi = new Bitmap(@"D:\Pro2\Društvo\Društvo\Resources\a.gif");
            // ev.Graphics.DrawImage(bi, ev.MarginBounds.Right - 70, yPos - 10);
            //zaradi velikosti slike zgornjemu robu prištejem 32 (velikost=32x32)
            topMargin += 32;
            line = "";
            //izris prazne vrstice
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            //izpis glave tabele
            line = "Poz. Datum Namen V dobro V breme Opombe";
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            // Izpis podatkov iz datoteke.
            while (count < linesPerPage && štVrstice < filter.Count)
            {
                string a; //namen skrajšan na 10 znakov
                string b; //opombe skrajšane na 10 znakov
                if (filter[štVrstice].Namen.Length > 10)
                    a = filter[štVrstice].Namen.Substring(0, 10);
                else a = filter[štVrstice].Namen;
                if (filter[štVrstice].Opombe.Length > 10)
                    b = filter[štVrstice].Opombe.Substring(0, 10);
                else b = filter[štVrstice].Opombe;
                double c = filter[štVrstice].Znesek; //v dobro ali breme?
                if (c > 0)
                    line = String.Format("{0,3}", (štVrstice + 1)) + " " + filter[štVrstice].Datum.ToShortDateString() + " " +
                    String.Format("{0,10}", a) + " " +
                    String.Format("{0,10:c}", filter[štVrstice].Znesek) + " " +
                    String.Format("{0,10}", b);
                else
                    line = String.Format("{0,3}", (štVrstice + 1)) + " " + filter[štVrstice].Datum.ToShortDateString() + " " +
                    String.Format("{0,10}", a) + " " +
                    String.Format("{0,10:c}", filter[štVrstice].Znesek) + " " +
                    String.Format("{0,10}", b);
                štVrstice++;
                yPos = topMargin + (count *
                printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
                line = "";
            }
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            //izpis vrstice skupaj
            line = String.Format("{0,24}", "Skupaj") + " " +
            String.Format("{0,10:c}", znesekVDobro) + " " +
            String.Format("{0,10:c}", znesekVBreme) + " " +
            String.Format("{0,10:c}", saldo);
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            // če še nismo na koncu datoteke, pojdi na novo stran
            if (štVrstice != filter.Count)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void Tiskanje_Load(object sender, EventArgs e)
        {
            NaložiPodatke();
        }
        private void RačunajVsote()
        {
            foreach (Darovi x in filter)
            {
                if (x.Znesek >= 0)
                    znesekVDobro += x.Znesek;
                if (x.Znesek < 0)
                    znesekVBreme += x.Znesek;
            }
            saldo = znesekVDobro + znesekVBreme;
        }
        private void PreveriDatume()
        {
            DateTime prvi = dateTimePicker1.Value;
            DateTime drugi = dateTimePicker2.Value;
            foreach(Darovi x in spremembe)
            {
                if (x.Datum >= prvi && x.Datum <= drugi)
                    filter.Add(x);
            }
        }
        private void NaložiPodatke()
        {
            FileStream fs = new FileStream(Resource1.pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Darovi d;
            try
            {
                while (true)
                {
                    d = (Darovi)bf.Deserialize(fs);
                    spremembe.Add(d);
                }
            }
            catch (SerializationException) { }
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreveriDatume();
            DialogResult a=  printDialog1.ShowDialog();
            if (a == DialogResult.OK)
                pd.Print();
        }
    }
}
