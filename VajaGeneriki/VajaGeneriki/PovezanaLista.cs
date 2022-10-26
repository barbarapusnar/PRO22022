using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class PovezanaLista<K,T> where K:IComparable
    {
        Vozel<K, T> glava;
        public PovezanaLista()
        {
            glava = new Vozel<K, T>();
        }
        public void Dodaj(K key, T item)
        {
            Vozel<K, T> nov = new Vozel<K, T>(key, item, glava.naslednji);
            glava.naslednji = nov;
        }
        public T Najdi(K key)
        {
            Vozel<K, T> trenutni = glava;
            while (trenutni.naslednji != null)
            {
                if (trenutni.ključ.CompareTo(key)==0)
                    break;
                else
                    trenutni = trenutni.naslednji;
            }
            return trenutni.vsebina;
        }
    }
}
