using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthDataContext dc = new NorthDataContext();
            //izberi vsa imena podjetij
            var x1 = from a in dc.Customers
                     select a.CompanyName;
            Console.WriteLine("Imena podjetij");
            //foreach(var y in x1)
            //    Console.WriteLine(y);
            //imena podjetji+imena kontaktov
            var x2 = from a in dc.Customers
                     select new {Podjetje= a.CompanyName,Kontakt= a.ContactName };
            //Console.WriteLine("Imena podjetij in kontaktov");
            //foreach (var y in x2)
            //    Console.WriteLine(y.Podjetje+" "+y.Kontakt);
            var x3 = from a in dc.Orders
                     select a;
            //Console.WriteLine("Naročila");
            //foreach (var y in x3)
            //    Console.WriteLine(y.CustomerID+" "+y.Customer.CompanyName+" "+y.OrderID);
            var x4 = from a in dc.Orders
                     from b in a.Order_Details
                     where a.OrderID == 11076
                     select b;
            Console.WriteLine("Naročilo 11076");
            foreach (var y in x4)
            {
                Console.WriteLine(y.Order.OrderDate+" "+y.ProductID+" "+y.Quantity);
            }
            //Order_Detail d = new Order_Detail();
            //d.OrderID = 11076;
            //d.ProductID = 7;
            //d.UnitPrice = 0.2m;
            //d.Quantity = 88;
            //d.Discount = 0;
            //Vstavi(d);
            //Console.WriteLine("Naročilo 11076 po vstavljanju");
            //foreach (var y in x4)
            //{
            //    Console.WriteLine(y.Order.OrderDate + " " + y.ProductID + " " + y.Quantity);
            //}
            //Briši(11076, 7);
            //Console.WriteLine("Naročilo 11076 po brisanju");
            //foreach (var y in x4)
            //{
            //    Console.WriteLine(y.Order.OrderDate + " " + y.ProductID + " " + y.Quantity);
            //}
            Order_Detail d = new Order_Detail();
            d.OrderID = 11076;
            d.ProductID = 6;
            d.UnitPrice = 0.2m;
            d.Quantity = 100;
            d.Discount = 0;
            Posodobi(d,dc);
            Console.WriteLine("Naročilo 11076 po posodabljanju" );
            foreach (var y in x4)
            {
                Console.WriteLine(y.Order.OrderDate + " " + y.ProductID + " " + y.Quantity);
            }
            Console.ReadLine();
        }
        private static void Vstavi(Order_Detail d)
        {
            NorthDataContext dc = new NorthDataContext();
            try
            {
                Order_Detail od = new Order_Detail();
                od.OrderID = d.OrderID;
                od.ProductID = d.ProductID;
                od.UnitPrice = d.UnitPrice;
                od.Quantity = d.Quantity;
                od.Discount = d.Discount;
                dc.Order_Details.InsertOnSubmit(od);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Briši(int idN, int id)
        {
            NorthDataContext dc = new NorthDataContext();

            try
            {
                var x = (from a in dc.Order_Details
                        where a.OrderID == idN && a.ProductID == id
                        select a).FirstOrDefault();
                dc.Order_Details.DeleteOnSubmit(x);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Posodobi(Order_Detail d,NorthDataContext dc)
        {
           
            try {
                var x = (from a in dc.Order_Details
                         where d.ProductID == a.ProductID && a.OrderID == d.OrderID
                         select a).FirstOrDefault();
                if (x != null)
                {
                    x.Quantity = d.Quantity;
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
