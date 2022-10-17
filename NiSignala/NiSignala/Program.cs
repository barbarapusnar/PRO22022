using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kupec janez = new Kupec();
            //janez.Ime = "Janez Novak";
            //janez.BeležiKlic(10, TipKlica.Stacionarno);
            //Console.WriteLine(janez.Ime+" dolguje "+janez.Stanje);
            //Console.WriteLine("get type "+janez.GetType());
            //Console.WriteLine("to string " + janez.ToString());
            //Kupec alenka = new Kupec60();
            //alenka.Ime = "Alenka Novak";
            //alenka.BeležiKlic(100, TipKlica.Mobilno);
            //Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);
            //Console.WriteLine("get type " + alenka.GetType());
            //Console.WriteLine("to string " + alenka.ToString());
            Kupec[] vsiKupci = new Kupec[2];
            vsiKupci[0] = new Kupec();
            vsiKupci[1] = new ZlatiKupec();
            vsiKupci[1].Ime = "Alenka Novak";
            vsiKupci[1].BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(vsiKupci[1].ToString());
            Console.ReadLine();
        }
    }
}
