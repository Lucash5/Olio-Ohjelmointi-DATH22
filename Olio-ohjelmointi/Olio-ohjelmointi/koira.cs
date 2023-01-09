using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    internal class koira
    {
        public string Nimi;
        public string Rotu;
        public int Ikä;

        public koira(string nimi, string rotu, int ikä)
        {
            Nimi = nimi;
            Rotu = rotu;
            Ikä = ikä;
        }
        public void HaeTiedot()
        {
            Console.WriteLine("Koiran nimi on " + Nimi);
            Console.WriteLine("Koiran ikä on " + Ikä);
            Console.WriteLine("Koiran rotu on " + Rotu);
        }

        public void Hauku()
        {
            Console.WriteLine(Nimi + ": Woof Woof");
        }

    }

}
