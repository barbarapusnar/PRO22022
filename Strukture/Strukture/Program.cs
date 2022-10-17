using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    internal class Program
    {
        struct Vektor
        {
            public double x;
            public double y, z;
            public override string ToString()
            {
                return "(" + x + ", " + y + ", " + z + ")";
            }
        }
        static void Main(string[] args)
        {
            Vektor v;
            v.x = 1;
            v.y = -1;
            v.z = 0;
            Vektor a = new Vektor();
            a.x = 2;a.y = 2;a.z = 3;
            Console.WriteLine(v.ToString());
            Console.WriteLine(a.ToString());
            Console.ReadLine();
        }
    }
}
