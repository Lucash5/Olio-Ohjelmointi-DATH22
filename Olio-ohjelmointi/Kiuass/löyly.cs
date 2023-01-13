using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuass
{
    internal class löyly
    {

        public bool onkopäällä;

        public float temperature;
        public float kosteus;

        public void PistäPäälle(bool v)
        {


            if (v)
            {
                onkopäällä = true;
                Console.WriteLine("Laitoit kiukaan päälle");
                temperature = 20f;
            }
            else if (!v) // Huutomerkki saa kääntää if lauseen ehdon ja tarkistaa jos arvo on false
            {
                onkopäällä = false;
                Console.WriteLine("sammutit kiukaan");
                temperature = 0f;
            }

        }
        
        public void LisääLämpöä()
        {
            if (onkopäällä == true)
            {
           temperature = temperature + 1;
            Console.WriteLine("Lämpötila on nyt " + temperature);
            }
            else
            {
                Console.WriteLine("Kiuas ei ole päällä");
            }
        }

        public void LisääKosteutta()
        {
            if (onkopäällä == true)
            {
                float kosteusmodifier = temperature / 50;
            kosteus = kosteus + kosteusmodifier;
            Console.WriteLine("Kosteus on nyt " + kosteus);
            }
            else
            {
                Console.WriteLine("Kiuas ei ole päällä");
            }
        }
    }
}
