using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Generiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sklad a = new Sklad();
            a.Push(1);a.Push("!");

            SkladGen<string> b = new SkladGen<string>();
            b.Push("1");b.Push("dva");

            SkladGen<double> c = new SkladGen<double>();
            c.Push(1);c.Push(Math.PI);
           
            Console.ReadLine();
        }
    }
}
