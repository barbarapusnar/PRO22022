using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaElektrika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektrikaEntities1 en = new ElektrikaEntities1();
            //1. izberi čas meritve in skupno moč
            //ista poizvedba z lambda izrazom
            //2. izberi čas meritve in skupno moč za datum 18.8.2013
            DateTime izbraniDatum = DateTime.Parse("18.8.2013");
            var x2 = (from a in en.Meritve
                     where DbFunctions.TruncateTime(a.ZapisČas.Value) == izbraniDatum
                     select new { Čas = a.ZapisČas, Moč = a.kW1 + a.kW2 + a.kW3 }).ToList();

            //3. izračunaj povprečno moč za datum 18.8.2013
            //4. izračunaj maximalno moč za ta datum
            //5. izračunaj minimalno moč za ta datum
            //6. izračunaj povprečno moč po urah za dan 18.8.2013
            var x6 = from a in en.Meritve
                      where DbFunctions.TruncateTime(a.ZapisČas.Value) == izbraniDatum
                      group a by a.ZapisČas.Value.Hour into z
                      select new { Ura = z.Key, Moč = z.Average(e => e.kW1 + e.kW2 + e.kW3) };
            foreach (var y in x6)
            {
                Console.WriteLine(y.Ura+" "+y.Moč);
            }
            //7. izračunaj 15 minutna povprečja za 18.8.2013
            var x7 = from a in en.Meritve
                     where DbFunctions.TruncateTime(a.ZapisČas.Value) == izbraniDatum
                     let ura = a.ZapisČas.Value.Hour
                     let min = a.ZapisČas.Value.Minute
                     let quater = min / 15
                     group a by new { ura, quater } into z
                     orderby  z.Key 
                     select new { Ura = z.Key.ura, Četrt = z.Key.quater, Moč = z.Average(e => e.kW1 + e.kW2 + e.kW3) };
            foreach (var y in x7)
            {
                Console.WriteLine(y.Ura+" "+y.Četrt+" Moč "+y.Moč);
            }
            Console.ReadLine();
        }
    }
}
