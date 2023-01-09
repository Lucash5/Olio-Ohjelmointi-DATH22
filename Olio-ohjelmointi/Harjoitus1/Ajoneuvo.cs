using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Ajoneuvo
    {
        public string Merkki;
        public int Nopeus;
        public int Renkaat;

    public Ajoneuvo(string merkki, int nopeus, int renkaat)
    {
            Merkki = merkki;
            Nopeus = nopeus;
            Renkaat = renkaat;

    }

    public void TulostaData()
    {
            Console.WriteLine("Merkki on " + Merkki);
            Console.WriteLine("Nopeus on " + Nopeus + " kilometriä tunnissa");
            Console.WriteLine("Renkaita on " + Renkaat);
        }
    }
}
