using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KličiMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imeDatoteke = @"D:\Pro22022\b.txt";
            //tukaj lahko beremo ime datoteke
            Bralec osebe = new Bralec();
            try
            {
                osebe.Odpri(imeDatoteke);
                for (int k = 0; k < osebe.NOseb; k++)
                {
                    osebe.ObravnavajNaslednjega();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Datoteka " + imeDatoteke + " ne obstaja");
            }
            catch (KličiMeException x)
            {
                Console.WriteLine("Datoteka ima napačno strukturo");
                Console.WriteLine(x.Message);
            }
            catch (Exception y)
            {
                Console.WriteLine("Neznana napaka "+y.Message);
            }
            Console.ReadLine();
        }
    }
}
