using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UporabaFunc
{
    internal class Program
    {
        //delegate string Spremeni(string s);
        static void Main(string[] args)
        {
            //1. Spremeni a = VVelike;
            // 2. Func<string, string> a = VVelike;
            //3.
            //Func<string, string> a = delegate (string s) { return s.ToUpper(); };
            //4. lambda izraz
            //Func<string, string> a = s => s.ToUpper();
            //string ime = "Barbara";
            //Console.WriteLine(a(ime));
            int[] števila = { 5, 10, 8, 3, 6, 12 };
            //poizvedovalni=deklarativni linq
            var x1 = from z in števila
                     where z % 2 == 0
                     orderby z
                     select z;
            //z metodami
            var x2 = števila.Where(e => e % 2 == 0).OrderBy(e => e);
            foreach (var y in x1)
            {
                Console.Write(y+"\t");
            }
            Console.WriteLine();
            foreach (var y in x2)
            {
                Console.Write(y + "\t");
            }
            Console.ReadLine();

        }
        //public static  string VVelike(string s)//je tipa spremeni
        //{
        //    return s.ToUpper();
        //}
    }
}
