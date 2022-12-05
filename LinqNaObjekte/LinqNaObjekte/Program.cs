using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNaObjekte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kupci = new[]{
             new {KupecID=1,Ime="Janez",Priimek="Kranjski",Podjetje="Kolo"},
             new {KupecID=2,Ime="Miha",Priimek="Polanc",Podjetje="Djak"},
             new {KupecID=3,Ime="Gašper",Priimek="Rupnik",Podjetje="Fitnes"},
             new {KupecID=4,Ime="Martin",Priimek="Bolčina",Podjetje="Kolo"},
             new {KupecID=5,Ime="Alenka",Priimek="Puncer",Podjetje="Kolo"},
             new {KupecID=6,Ime="Mojca",Priimek="Širok",Podjetje="Djak"},
             new {KupecID=7,Ime="Peter",Priimek="Gulin",Podjetje="Djak"},
             new {KupecID=8,Ime="Pavel",Priimek="Gantar",Podjetje="Inn"},
             new {KupecID=9,Ime="David",Priimek="Niven",Podjetje="Inn"},
             new {KupecID=10,Ime="Erik",Priimek="Kompara",Podjetje="Fitnes"}
               };
            var podjetja = new[] {
             new {ImePodjetja="Kolo",Mesto="Nova Gorica",Država="Slovenija"},
             new {ImePodjetja="Djak",Mesto="Nova Gorica",Država="Slovenija"},
             new {ImePodjetja="Fitnes",Mesto="Ljubljana",Država="Slovenija"},
             new {ImePodjetja="Inn",Mesto="Trst",Država="Italija"},
            };
            //1. napiši LINQ stavek s katerim izbereš in izpišeš vsa imena kupcev
            var x1 = from a in kupci
                     select a.Ime;
            Console.WriteLine("1. naloga");
            foreach(var y in x1)
                Console.WriteLine(y);

            //2. napiši LINQ stavek katerim izbereš in izpišeš imena in
            //priimke kupcev
            var x2 = from a in kupci
                     select new { a.Ime, a.Priimek };
            Console.WriteLine("2. naloga");
            foreach (var y in x2)
                Console.WriteLine(y.Ime+" "+y.Priimek);

            //3. izberi in izpiši vsa imena podjetji iz Slovenije
            var x3 = from a in podjetja
                     where a.Država == "Slovenija"
                     select a.ImePodjetja;
            Console.WriteLine("3. naloga");
            foreach (var y in x3)
                Console.WriteLine(y);
            //4. Izpiši imena podjetji urejena po abecedi
            var x4 = from a in podjetja
                     orderby a.ImePodjetja
                     select a.ImePodjetja;
            Console.WriteLine("4. naloga");
            foreach (var y in x4)
                Console.WriteLine(y);
            //5. izpiši koliko je različnih podjetji
            var x5 = x4.Count();
            Console.WriteLine("5. naloga");
            Console.WriteLine(x5);
            //6. izpiši koliko podjetij je iz Italije
            var x6 = (from a in podjetja
                      where a.Država == "Italija"
                      select a).Count();
            Console.WriteLine("6. naloga");
            Console.WriteLine(x6);
            //7. izpiši iz koliko različnih držav imamo podjetja
            var x7 = (from a in podjetja
                      select a.Država).Distinct().Count();
            Console.WriteLine("7. naloga");
            Console.WriteLine(x7);
            //8.Izpiši priimke kupcev po podjetjih
            var x8 = from a in kupci
                     group a by a.Podjetje into p
                     select p;
            Console.WriteLine("8. naloga");
            foreach (var y in x8)
            {
                Console.WriteLine("Podjetje "+y.Key);
                foreach (var y1 in y)
                {
                    Console.WriteLine("\t"+y1.Priimek);
                }
            }
            Console.ReadLine();
        }
    }
}
