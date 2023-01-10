using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Kappale
    {
        public string nimi;
        public string kesto; //3:50

        public Kappale(string nimi, string kesto)
        {
            this.nimi = nimi;
            this.kesto = kesto;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("--- Nimi: " + nimi + " - " + kesto);
        }
    }
}
