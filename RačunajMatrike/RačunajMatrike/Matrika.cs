using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RačunajMatrike
{
    internal class Matrika
    {
        //tabela 3x3 realnih števil
        double[,] m = new double[3, 3];
        //indekser
        public double this[int x, int y]
        {
            get { return m[x, y]; }
            set { m[x, y] = value; }
        }
        public void Izpis()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m[k,j]+"\t");
                }
                Console.WriteLine();
            }
        }
        public static Matrika operator *(Matrika a, Matrika b)
        {
            Matrika r = new Matrika();
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //r[k, j] = a[k, 0] * b[0, j] + a[k, 1] * b[1, j] + a[k, 2] * b[2, j];
                    r[k, j] = 0;
                    for(int z=0;z<3;z++)
                    { 
                        r[k, j] += a[k, z] * b[z, j]; 
                    }//konec for z
                }//konec for j
            }//konec for k
            return r;
        }
    }
}
