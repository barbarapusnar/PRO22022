using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaLinqToEntities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adw nw = new Adw();
            var x1 = from p in nw.Product
                         where p.ProductNumber.StartsWith("FR")
                         select p.Name;
            nw.Database.Log = Console.WriteLine;
            //foreach (var y in x1)
            //{
            //    Console.WriteLine(y);
            //}
            var x2 = x1.Count();
            Console.WriteLine("Produktov na FR imamo "+x2);
            //posodabljanje
            var x3 = (from p in nw.Product
                     where p.ProductNumber == "FR-R92B-58"
                     select p).SingleOrDefault();
            if (x3 != null)
            {
                x3.ListPrice = 1700;
            }
            nw.SaveChanges();
            Console.WriteLine(x3.Name+" "+x3.ListPrice+" "+x3.ProductNumber);
            //vstavljanje
            ProductCategory a = new ProductCategory();
            //vnos vseh obveznih podatkov
            a.Name = "Moja nova kategorija";
            a.ModifiedDate = DateTime.Now;
            //
            //nw.ProductCategory.Add(a);
            //nw.SaveChanges();

            ProductCategory y = (from x in nw.ProductCategory
                                 where x.Name == "Moja nova kategorija"
                                 select x).SingleOrDefault();

            //nw.ProductCategory.Remove(y);
            //nw.SaveChanges();

            Console.ReadLine();
        }
    }
}
