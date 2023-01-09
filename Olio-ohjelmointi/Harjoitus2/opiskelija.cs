using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class opiskelija
    {
        public string Nimi;
        public string Id;
        public int Opintopisteet;
        public opiskelija(string nimi, string id, int opintopisteet)
        {
            Nimi = nimi;
            Id = id;
            Opintopisteet = opintopisteet;
        }
        public void Tulostatiedot()
        {
            Console.WriteLine("Nimi on " + Nimi);
            Console.WriteLine("Id on " + Id);
            Console.WriteLine("Opintopisteitä on " + Opintopisteet);
            Console.WriteLine();
        }
    }
}
