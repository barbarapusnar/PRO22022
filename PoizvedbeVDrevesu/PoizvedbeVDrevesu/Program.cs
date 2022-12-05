using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree1;

namespace PoizvedbeVDrevesu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Delaj();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

        }

        private static void Delaj()
        {
            Tree<Zaposleni> z = 
                new Tree<Zaposleni>(
                     new Zaposleni { Id = 1, Ime = "Miha", Priimek = "Polanc", Oddelek = "IT" });
            z.Insert(new Zaposleni { Id = 2, Ime = "Andrej", Priimek = "Bratina", Oddelek = "Marketing" });
            z.Insert(new Zaposleni { Id = 4, Ime = "Lucija", Priimek = "Krkoč", Oddelek = "Prodaja" });
            z.Insert(new Zaposleni { Id = 6, Ime = "Peter", Priimek = "Gulin", Oddelek = "IT" });
            z.Insert(new Zaposleni { Id = 3, Ime = "Franc", Priimek = "Milčinski", Oddelek = "Marketing" });
            z.Insert(new Zaposleni { Id = 5, Ime = "Pavel", Priimek = "Matko", Oddelek = "Prodaja" });
            //1. napiši kodo, ki izpiše vse oddelke

            //2. napiši kodo, ki izpiše vse različne oddelke
            //var x1 = (from a in z
            //          select a.Oddelek).Distinct();
            //Console.WriteLine("2.naloga");
            //foreach (var y in x1)
            //    Console.WriteLine(y);
            //3. napiši kodo, ki izpiše vse zaposlene v oddelku IT
            var x3 = (from a in z
                     where a.Oddelek == "IT"
                     select a).ToList();
            Console.WriteLine("3.naloga");
            foreach (var y in x3)
                Console.WriteLine(y.ToString());
            //4. napiši kodo, ki izpiše zaposlene po oddelkih
            //var x4 = from a in z
            //         group a by a.Oddelek;
            //Console.WriteLine("4.naloga");
            //foreach (var y in x4)
            //{
            //    Console.WriteLine("Oddelek "+y.Key);
            //    foreach (var y1 in y)
            //    {
            //        Console.WriteLine(" \t"+y1.ToString());
            //    }
            //}
            z.Insert(new Zaposleni { Id = 8, Ime = "Barbara", Priimek = "Pušnar", Oddelek = "IT" });
            Console.WriteLine("Po vstavljanju");
            foreach (var y in x3)
                Console.WriteLine(y.ToString());
        }
    }
}
