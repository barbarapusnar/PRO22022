using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;

namespace KličiMe
{
    internal class Bralec
    {
        FileStream fs;
        StreamReader sr; //iz katere datoteke
        uint število; //koliko oseb naj kličem
        public void Odpri(string imeDatoteke)
        {
            fs = new FileStream(imeDatoteke, FileMode.Open);
            sr = new StreamReader(fs);
            try 
            {
                string prvaVrstica = sr.ReadLine();
                število = uint.Parse(prvaVrstica);
            }
            catch(FormatException)
            {
                Console.WriteLine("Prvo število v datoteki ni pozitivno celo");
            }
        }
        public uint NOseb
        { 
        get { return število; } //getter metoda za spremenljivko število
        }

        public void ObravnavajNaslednjega()
        {
            try
            {
                string ime = sr.ReadLine();
                if (ime == null)
                {
                    throw new KličiMeException("Ni dovolj imen");
                }
                if (ime[0] == 'Z')
                {
                    throw new TajniAgentException(ime);
                }
                Console.WriteLine("Pokliči " + ime);
            }
            catch (TajniAgentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
