using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class ZlatiKupec:Kupec
    {
        public override void BeležiKlic(int min, TipKlica tip)
        {
            base.BeležiKlic(min, tip);
            stanje = stanje * 0.9m;
        }
    }
}
