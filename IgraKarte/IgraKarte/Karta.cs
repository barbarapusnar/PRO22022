using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraKarte
{
    class Karta
    {
        // to je isto kot
       // Barve b;
        //internal Barve B { get => b; set => b = value; }
        public Barve Barva { get; set; }
        public Vrednosti Vrednost { get; set; }
        public string Ime { get; set; }
     

        public Karta(Barve b,Vrednosti v)
        {
            Barva = b;
            Vrednost = v;
            Ime = v + " " + b;
        }
    }
}
