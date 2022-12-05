using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodDelegati
{
   
    internal class Program
    {
        public delegate bool FunkcijaZANize(string s);
        static void Main(string[] args)
        {
            string[] imena = { "Adam","Alan","Bob","Steve","Jim","Aiden",
                               "Rob","Bill","Jacob","James"};
            
            Console.ReadLine();
        }
        public static List<String> DelajOperacijeNadNizi(string[] mojinizi,
            FunkcijaZANize mojaFunkcija)
        {
            List<string> nova = new List<string>();
            foreach(var y in mojinizi)
            {
                if (mojaFunkcija(y))
                    nova.Add(y);
            }
            return nova;
        }
    }
}
