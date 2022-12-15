using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodDelegati
{
   
    internal class Program
    {
        //public delegate bool FunkcijaZANize(string s);
        static void Main(string[] args)
        {
            string[] imena = { "Adam","Alan","Bob","Steve","Jim","Aiden",
                               "Rob","Bill","Jacob","James"};
            // FunkcijaZANize anonimna = delegate (string s) { return s.StartsWith("A"); };
            Func<string, bool> anonimna = s => s.StartsWith("A");
            List<string> naA = DelajOperacijeNadNizi(imena, anonimna);
            List<string> n = DelajOperacijeNadNizi(imena, 
                delegate(string s) { return s.EndsWith("n"); }
                );
            List<string> x = DelajOperacijeNadNizi(imena, s => s.StartsWith("A"));
            foreach(var s in n)
            { Console.WriteLine(s); }
            Console.ReadLine();
        }
        public static List<String> DelajOperacijeNadNizi(string[] mojinizi,
            Func<string,bool> mojaFunkcija)
        {
            List<string> nova = new List<string>();
            foreach(var y in mojinizi)
            {
                if (mojaFunkcija(y))
                    nova.Add(y);
            }
            return nova;
        }
        //public static bool ZačneZA(string s)
        //{
        //    return s.StartsWith("A");
        //}
        //public static bool KončaZn(string s)
        //{

        //    return s.EndsWith("n");
        //}
    }
}
