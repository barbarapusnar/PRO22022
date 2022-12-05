using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaAirways
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdriaDataContext dc = new AdriaDataContext();
            //1. izpiši vsa imena in kode modelov letal iz
            //tabele model
            var x1 = from a in dc.MODELs
                     select new { Ime=a.MOD_IME,Koda= a.MOD_KODA };
            Console.WriteLine("Naloga 1");
            foreach (var y in x1)
            {
                Console.WriteLine(y.Ime+"\t"+y.Koda);
            }
            //2. izpiši imena vseh zaposlenih, ki so piloti
            var x2 = from a in dc.PILOTs
                     select new { a.ZAPOSELNI.ZAP_IME };
            //3. izpiši imena in priimke vseh strank

            //4. izpiši podatke o čarterskih poletih - datum in cilj
            //zbrane po strankah

            //5. izpiši podatke o čarterskih poletih - datum in cilj,
            //zbrane po pilotih

            //6. izpiši podatke o čarterskih poletih urejene po ciljih

            //7. razvrsti čarterske polete po urah čakanja-
            //izpiši cilj in ure čakanja


            //8. vstavi stranko s priimkom Saksida, imenom Miran v tabelo Strank
            //upoštevaj, da je koda stranke samoštevilo
            STRANKA nova = new STRANKA();
            nova.STR_IME = "Miran";
            nova.STR_PRIIMEK = "Saksida";
            dc.STRANKAs.InsertOnSubmit(nova);
            dc.SubmitChanges();

            //9. stranki s priimkom Ramas spremeni telefon v 123-456
            //s poizvedbo dobi stanko ENO, ki se piše Ramas x9

            //posodobi rezultatu telefon x9.Telefon=nova telefonska
            //samo shrani spremembe

            //10. izbriši stranke s priimkom Smith
            //s poizvedbo dobi vse stranke, ki se pišejo Smith
            //z zanko preglej rezultat in na vsakem koraku kliči DeleteOnSubmit
            //na koncu shrani spremembe
            var x10 = from a in dc.STRANKAs
                      where a.STR_PRIIMEK == "Smith"
                      select a;
            foreach(var y in x10)
            {
                dc.STRANKAs.DeleteOnSubmit(y);
            }
            dc.SubmitChanges();
            Console.ReadLine();
        }
    }
}
