using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VakaLinq
{
    internal class Urejanje
    {
        public static void Sort<T>(List<T> sortList, Func<T, T, bool> kriterij)
        {
            //bubble sort
            bool sorted = true;
            do {
                sorted = false;
                for (int k = 0; k < sortList.Count - 1; k++)
                {
                    if (kriterij(sortList[k + 1], sortList[k]))
                    {
                        T temp = sortList[k];
                        sortList[k] = sortList[k + 1];
                        sortList[k + 1] = temp;
                    }
                }
            
            } while (sorted);
        }
    }
}
