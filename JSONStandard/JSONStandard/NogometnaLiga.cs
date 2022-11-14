using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStandard
{
    public class NogometnaLiga
    {
        public Ekipa[] liga = new Ekipa[10];
        public NogometnaLiga()
        {
            liga[0] = new Ekipa("Italija     ");
            liga[1] = new Ekipa("Španija     ");
            liga[2] = new Ekipa("Slovenija   ");
            liga[3] = new Ekipa("Anglija     ");
            liga[4] = new Ekipa("Nemčija     ");
            liga[5] = new Ekipa("Belgija     ");
            liga[6] = new Ekipa("San Marino  ");
            liga[7] = new Ekipa("Portugalska ");
            liga[8] = new Ekipa("Švedska     ");
            liga[9] = new Ekipa("Islandija   ");
            
        }
        int x = 0;
        int y = 1;
        int[] gor = {2,3,4,5 };
        int[] dol = { 9, 8, 7, 6 };
        int[,] pari = new int[10, 10];
        //če je pari[3,4]=9, pomeni, da se ekipi 3 in 4
        //pomerita v 9 kolu
        public void NapolniPare(int kolo)
        {
            pari[x, y] = kolo;
            for (int k = 0; k < 4; k++)
            {
                pari[gor[k], dol[k]] = kolo;
            }
            //pripravi naslednje kolo
            int temp = y;
            y = dol[0];dol[0] = dol[1];dol[1] = dol[2];dol[2] = dol[3];
            dol[3] = gor[3];gor[3] = gor[2];gor[2] = gor[1];
            gor[1] = gor[0];
            gor[0] = temp;
        }
        public void IzdelajTurnir()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
                NapolniPare(kolo);
        }
        public void IzpišiTurnir()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
            {
                Console.WriteLine("Pari "+kolo+". kola");
                for (int k = 0; k < 10; k++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (pari[k,j]==kolo)
                        Console.WriteLine(liga[k].Ime+" : "+liga[j].Ime);
                    }
                }
            }
        }
        public void ObdelajRezultat(int kolo)
        {
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (pari[k, j] == kolo)
                    {
                       Console.Write(liga[k].Ime + " : " + liga[j].Ime);
                        string odgovor = Console.ReadLine(); //v obliki 2:3
                        string[] deli = odgovor.Split(':');
                        int ena = int.Parse(deli[0]); //rezultat ekipe k
                        int dva = int.Parse(deli[1]);//goli ekipe j
                        liga[k].VnesiRezultat(ena, dva);
                        liga[j].VnesiRezultat(dva, ena);
                    }//konec if
                }//konec for j
            }//konec for k
        }//konec obdelaj rezultat
        public void IzpišiLestvico()
        {
            for (int k = 0; k < 10; k++)
                liga[k].Izpis();
        }
    }
}
