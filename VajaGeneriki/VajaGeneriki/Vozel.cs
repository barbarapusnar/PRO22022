using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class Vozel<K,T>
    {
        public K ključ;
        public T vsebina;
        public Vozel<K, T> naslednji;
        public Vozel()
        {
            ključ = default(K);
            vsebina = default(T);
            naslednji = null;
        }
        public Vozel(K k,T t,Vozel<K,T> n)
        {
            ključ = k;vsebina = t;naslednji = n;
        }
    }
}
