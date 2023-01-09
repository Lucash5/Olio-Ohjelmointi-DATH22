using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            opiskelija opiskelija1 = new opiskelija("Lucas", "ABC69", 10000000);
            opiskelija opiskelija2 = new opiskelija("Niko", "Bals420", 500000000);
            opiskelija opiskelija3 = new opiskelija("Waltteri", "Sus21", 75000000);

            opiskelija1.Tulostatiedot();
            opiskelija2.Tulostatiedot();
            opiskelija3.Tulostatiedot();

        }
    }
}
