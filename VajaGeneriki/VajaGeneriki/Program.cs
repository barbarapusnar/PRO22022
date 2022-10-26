using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PovezanaLista<int, string> x = new PovezanaLista<int, string>();
            x.Dodaj(1, "aaaa");
            x.Dodaj(5, "cccccc");
            x.Dodaj(2, "ababa");
            string r = x.Najdi(5);
            Console.WriteLine("Našel sem "+r);
            Console.ReadLine();
        }
    }
}
