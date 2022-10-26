using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraKarte
{
    internal class Kup
    {
        List<Karta> kup;
        Random r = new Random();
        public Kup()
        {
            kup = new List<Karta>();
            for (int b = 0; b < 4; b++)
            {
                for (int v = 1; v <= 13; v++)
                {
                    kup.Add(new Karta((Barve)b, (Vrednosti)v));
                }
            }
        }
        public Kup(IEnumerable<Karta> začetek)
        {
            kup = new List<Karta>(začetek);
        }
        public void Add(Karta nova)
        {
            kup.Add(nova);
        }
        public int Count
        {
            get { return kup.Count; }
        }
        public void Sort()
        {
            kup.Sort(new Primerjava());
        }
        public List<string> ImenaKart()
        {
            List<string> imena = new List<string>();
            foreach (Karta k in kup)
                imena.Add(k.Ime);
            return imena;
        }
        public Karta Deli(int indeks)
        {
            Karta x = kup[indeks];
            kup.RemoveAt(indeks);
            return x;
        }
        public void Mešaj()
        {
            List<Karta> zmešano = new List<Karta>();
            while (kup.Count > 0)
            {
                int x = r.Next(kup.Count);
                zmešano.Add(kup[x]);
                kup.RemoveAt(x);
            }
            kup = zmešano;
        }
    }
}
