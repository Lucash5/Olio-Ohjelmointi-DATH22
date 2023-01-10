using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Laskin.erotus(14, 15));
            Console.WriteLine(Laskin.summa(14, 15));
            Console.WriteLine(Laskin.kertolasku(14, 15));
            Console.WriteLine(Laskin.jakolasku(14, 15));
        }
    }
}
