using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            koira koira1 = new koira("batman", "boxer", 10);

            koira1.HaeTiedot();

            koira1.Hauku();
        }



    }
}
