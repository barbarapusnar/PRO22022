using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzjemeOsnovne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vnos;
            while (true)
            {
                try
                {
                    Console.WriteLine("Vnesi število med 0 in 5 ali return za konec");
                    vnos = Console.ReadLine();
                    if (vnos == "")
                        break;
                    int indeks = int.Parse(vnos);
                    if (indeks < 0 || indeks > 5)
                        throw new IndexOutOfRangeException("Napačen vnos");
                    Console.WriteLine("Vnesel si " + indeks);
                }
                catch (IndexOutOfRangeException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception y)
                {
                    Console.WriteLine("Bolj splošna izjema " + y.Message);
                }
                catch
                {
                    Console.WriteLine("Druga izjema");
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
