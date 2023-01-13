using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            löyly kiuas = new löyly();
            

            while (true)
            {

            string syöte = Console.ReadLine();

                if (syöte == "on")
                {
                   kiuas.PistäPäälle(true);
                }
                else if (syöte == "off")
                {
                    kiuas.PistäPäälle(false);
                }

                if (syöte == "lisää lämpöä")
                {
                    kiuas.LisääLämpöä();
                }

                if (syöte == "löylyä")
                {
                    kiuas.LisääKosteutta();
                }



            }
        }
    }
}
