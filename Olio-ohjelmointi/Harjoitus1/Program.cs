using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo1 = new Ajoneuvo("Bugatus", 480, 4);

            ajoneuvo1.TulostaData();
        }
    }
}
