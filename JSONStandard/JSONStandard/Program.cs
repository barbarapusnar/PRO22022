using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONStandard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NogometnaLiga n = new NogometnaLiga();
            //string oblikaZaPisanje = JsonConvert.SerializeObject(n, Formatting.Indented);
            //FileStream fs = new FileStream("liga.json", FileMode.Create);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write(oblikaZaPisanje);
            //sw.Close();
            //fs.Close();
            FileStream fs = new FileStream("liga.json", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string prebrano = sr.ReadToEnd();
            NogometnaLiga n = 
          (NogometnaLiga)JsonConvert.DeserializeObject<NogometnaLiga>(prebrano);
            foreach (Ekipa x in n.liga)
            {
                Console.WriteLine(x.ime);
            }
            Console.WriteLine("Konec");
            Console.ReadLine();
        }
    }
}
