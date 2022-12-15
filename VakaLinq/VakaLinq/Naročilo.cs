using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakaLinq
{
    internal class Naročilo
    {
        public int NaročiloID { get; set; }
        public DateTime Datum { get; set; }
        public Naslov NaslovDobave { get; set; }
        public Naslov NaslovRačuna { get; set; }
        public string ImeKupca { get; set; }
        public decimal Znesek { get; set; }
        public List<PodrobnostiNaročila> Elementi { get; set; }
        public Naročilo()
        {
            Elementi = new List<PodrobnostiNaročila>();
        }
        public static bool UrediPoDatumu(Naročilo n1, Naročilo n2)
        {
            return n1.Datum < n2.Datum;
        }
        public static bool UrediPoZnesku(Naročilo n1, Naročilo n2)
        {
            return n1.Znesek < n2.Znesek;
        }

    }
}
