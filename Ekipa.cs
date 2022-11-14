using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvropskoPrvenstvo
{
    class Ekipa
    {
        private string ime;
        private int štTekem;
        int štZmag;
        int štNeodločenih;
        int daniGoli;
        int prejetiGoli;

        public string Ime { get => ime; set => ime = value; }

        public Ekipa(string i)
        {
            ime = i;
            štTekem = 0;štZmag = 0;štNeodločenih = 0;
            daniGoli = 0;prejetiGoli = 0;
        }
        public void VnesiRezultat(int d, int p)
        {
            daniGoli += d;
            prejetiGoli += p;
            if (d > p)
                štZmag++;
            else
                if (d == p)
                štNeodločenih++;
            štTekem++;
        }
        public int ŠtTočk()
        {
            return 3 * štZmag + štNeodločenih;
        }
        public int GolRazlika()
        {
            return daniGoli - prejetiGoli;
        }
        public void Izpis()
        {
            Console.WriteLine(ime+" "+štTekem+" "
                +ŠtTočk()+" "+GolRazlika()
                +" "+daniGoli);
        }
        public bool BoljšaEkipa(Ekipa a)
        {
            if (this.ŠtTočk() > a.ŠtTočk())
                return true;
            else
                if (this.ŠtTočk() == a.ŠtTočk())
                {
                if (this.GolRazlika() > a.GolRazlika())
                {
                    return true;
                }
                else
                if (this.GolRazlika() == a.GolRazlika())
                {
                    if (this.daniGoli > a.daniGoli)
                        return true;
                }
                }
            return false;
        }

    }
}
