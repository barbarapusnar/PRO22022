using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karitas
{
    [Serializable]
    public class Darovi
    {
        public int ZapŠt { get; set; }
        public DateTime Datum { get; set; }
        public string Namen { get; set; }
        public double Znesek { get; set; }
        public string Opombe { get; set; }
        //zaradi pisanja v bin datoteko
        public Darovi()
        {

        }
    }
}
