using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace VajaBlueOcean
{
    internal class Program
    {
        static int novi = 0;
        static Random r = new Random();
        static void Main(string[] args)
        {
             while (true) {

                novi++;
                if (novi > 1)
                    break;
                BlueOceanDBEntities be = new BlueOceanDBEntities();
                PoslaniPodatki p = new PoslaniPodatki();
                p.auth_usr = "scng_test";
                p.remote_id = "1050717";
                p.amount = -(decimal)Math.Round(r.NextDouble() * 10, 2);
                p.game_id = "es_es-instant-roulette";
                p.game_session_id = "es636e3b4faced5-3593";
                p.currencycode = "EUR";
                //ta je lahko čuden, če poganjaš enega po enega
                p.round_id = "es172686716ff377d75bcf1d00-qh3rgasx3sjaezyd" + novi;
                p.final = true;
                p.is_bonus_win = false;
                p.is_freeround_bet = false;
                p.is_freeround_win = false;
                p.is_jackpot_win = false;
                p.is_rollback = false;
                p.balance = 100;
                p.nickname = "mojNick" + novi;
                p.platform_id = "2";
                p.agent_id = "3943";
                p.agent_prefix = "3623";
                p.group = "pantaloo2";
                p.DatumZapisa = DateTime.Now;
                Console.WriteLine(p);
                be.PoslaniPodatki.Add(p);
                be.SaveChanges();
                // zmaga, zguba
                PoslaniPodatki p1 = new PoslaniPodatki();
                p1.auth_usr = "scng_test";
                p1.remote_id = "1050717";
                if (r.NextDouble() < 0.2)
                    p1.amount = (decimal)Math.Round(r.NextDouble() * 100, 2);
                else
                    p1.amount = 0;
                p1.game_id = "es_es-instant-roulette";
                p1.game_session_id = "es636e3b4faced5-3593";
                p1.currencycode = "EUR";
                p1.round_id = "es172686716ff377d75bcf1d00-qh3rgasx3sjaezyd" + novi;
                p1.final = true;
                p1.is_bonus_win = false;
                p1.is_freeround_bet = false;
                p1.is_freeround_win = false;
                p1.is_jackpot_win = false;
                p1.is_rollback = false;
                p1.balance = 100;
                p1.nickname = "mojNick" + novi;
                p1.platform_id = "2";
                p1.agent_id = "3943";
                p1.agent_prefix = "3623";
                p1.group = "pantaloo2";
                p1.DatumZapisa = DateTime.Now;
                be.PoslaniPodatki.Add(p1);
                be.SaveChanges();
                Console.WriteLine(p1);
               

            }
            Console.ReadLine();
        }

        
      
    }
}
