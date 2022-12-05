using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Naročilo> naročilaList = setupNaročila();
            var n1 = from a in naročilaList
                     select a;
            Console.WriteLine("Izberi vse podatke");
            foreach (var x in n1)
            {
                Console.WriteLine(x.NaročiloID+" "+x.Datum.ToShortDateString());
            }
            //izberi samo datume
            var n2 = from a in naročilaList
                     select a.Datum;
            Console.WriteLine("Izberi datume");
            foreach (var x in n2)
            {
                Console.WriteLine(x.ToShortDateString());
            }
            var n3 = from a in naročilaList
                     select new {ID= a.NaročiloID,Datum= a.Datum };
            Console.WriteLine("Izberi številke in datume");
            foreach (var x in n3)
            {
                Console.WriteLine(x.ID+" "+x.Datum);
            }
            //izpis vseh podrobnosti naročil
            var n4 = from a in naročilaList
                     from b in a.Elementi
                     select b;
            Console.WriteLine("Izberi vse podrobnosti");
            foreach (var x in n4)
            {
                Console.WriteLine(x.ElementID+" "+x.ImeIzdelka);
            }
            //naročilo 9010
            var n5 = from a in naročilaList
                     where a.NaročiloID == 9010
                     select a;
            Console.WriteLine("Naročilo 9010");
            foreach (var x in n5)
            {
                Console.WriteLine(x.NaročiloID);
            }
            //vsa naročila, ki imajo več kot 2 vrstici
            var n6 = from a in naročilaList
                     where a.Elementi.Count > 2 
                     select new { a.NaročiloID };
            foreach (var x in n6)
            {
                Console.WriteLine(x.NaročiloID);
            }
            //agregati
            int[] števila = { 46, 24, 79, 35, 12, 57, 80, 68 };
            var r1 = števila.Count();
            var r2 = števila.Min();
            var r3 = števila.Sum();
            var r4 = števila.Average();
            Console.WriteLine("Vse števil je "+r1);
            Console.WriteLine("Minimum je "+r2);
            Console.WriteLine("Vsota je "+r3);
            Console.WriteLine("Povprečje je "+r4);
            //število naročil z več kot dvema vrsticama
            var n7 = (from a in naročilaList
                     where a.Elementi.Count > 2
                     select new { a.NaročiloID }).Count();
            var n8 = n6.Count();
            Console.ReadLine();
        }

        private static List<Naročilo> setupNaročila() 
        { 
            List<Naročilo> NaročiloList = new List<Naročilo>(); 
            Naročilo o1 = new Naročilo(); 
            o1.Datum = DateTime.Parse("12.7.2010"); 
            o1.NaročiloID = 9009; 
            PodrobnostiNaročila oi1 = new PodrobnostiNaročila(); 
            oi1.ElementID = 123; oi1.ImeIzdelka = "Mars"; oi1.Količina = 2; 
            o1.Elementi.Add(oi1); 
            PodrobnostiNaročila oi2 = new PodrobnostiNaročila(); 
            oi2.ElementID = 124; oi2.ImeIzdelka = "Kraš"; oi2.Količina = 3; 
            o1.Elementi.Add(oi2);
            
            Naročilo o2 = new Naročilo(); 
            o2.Datum = DateTime.Parse("12.1.2011"); 
            o2.NaročiloID = 9010; 
            PodrobnostiNaročila oi3 = new PodrobnostiNaročila(); 
            oi3.ElementID = 125; oi3.ImeIzdelka = "Mars"; oi3.Količina = 1; 
            o2.Elementi.Add(oi3); 
            PodrobnostiNaročila oi4 = new PodrobnostiNaročila(); 
            oi4.ElementID = 126; oi4.ImeIzdelka = "Extreme"; oi4.Količina = 5; 
            o2.Elementi.Add(oi4); 
            PodrobnostiNaročila oi5 = new PodrobnostiNaročila(); 
            oi5.ElementID = 127; oi5.ImeIzdelka = "Bazooka"; oi5.Količina = 1; 
            o2.Elementi.Add(oi5); 
            PodrobnostiNaročila oi6 = new PodrobnostiNaročila(); 
            oi6.ElementID = 128; oi6.ImeIzdelka = "Sadje"; oi6.Količina = 6; 
            o2.Elementi.Add(oi6); 
            NaročiloList.Add(o1); 
            NaročiloList.Add(o2); 
            return NaročiloList;
        }
    }
}
