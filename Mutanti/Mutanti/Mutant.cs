using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal abstract class Mutant : IPrikazovalnik
    {
        private string ime;
        private int stopnja;

        protected string Ime { get => ime; set => ime = value; }
        protected int Stopnja { get => stopnja; set => stopnja = value; }

        public void PrikažiInformacije()
        {
            Console.WriteLine("Mutant "+ime+" ima kvocient nevarnosti "+
                KvocientNevarnosti());
        }
        public abstract int KvocientNevarnosti();
    }
}
