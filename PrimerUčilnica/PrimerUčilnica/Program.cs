using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace PrimerUčilnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\PRO22022\PrimerUčilnica\PrimerUčilnica\Podatki.json",
                FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string prebrano = sr.ReadToEnd();
            //v prebrano so podatki, podatki so seznam
            List<Poglavja> uc = (List<Poglavja>)JsonConvert.DeserializeObject<List<Poglavja>>(prebrano);
            foreach (Poglavja x in uc)
            {
                Console.WriteLine(x.name);
                foreach (Module y in x.modules)
                {
                    Console.WriteLine("\t"+y.name);
                }
            }
            Console.ReadLine();
            
        }
    }
}
