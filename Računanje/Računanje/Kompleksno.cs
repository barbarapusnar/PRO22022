using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje
{
    internal class Kompleksno
    {
        double re;
        double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }
        public Kompleksno(double r, double i)
        {
            re = r;im = i;
        }
        //koda za +,-, *
        public static Kompleksno operator+(Kompleksno a,Kompleksno b)
        {
            Kompleksno r = new Kompleksno(0, 0);
            r.re = a.re + b.re;
            r.im = a.im + b.im;
            return r;
        }
    }
}
