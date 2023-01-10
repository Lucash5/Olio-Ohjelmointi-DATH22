using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Luodaan uusi albumi olio
            Albumi albumi = new Albumi("Evolve", "Imagine Dragons", "Poprock");

            albumi.LisääKappale(new Kappale("next to me", "3:50"));
            albumi.LisääKappale(new Kappale("I don't know why", "3:54"));
            albumi.LisääKappale(new Kappale("amogus rap remix", "3:10"));
            albumi.LisääKappale(new Kappale("Thunder", "2:30"));
            albumi.LisääKappale(new Kappale("Believer", "3:35"));

            albumi.TulostaTiedot();


            Staattinen_Luokka.StaattinenMetodi();

            float kilometriarvo = 143.50f;
            //Käytetään hyödyksi luotua  globaalista staattista luokkaa joka muuntaa kilometrit maileiksi
            float mailiarvo = Staattinen_Luokka.KmToMiles(kilometriarvo);
            Console.WriteLine(mailiarvo);
        }
    }
}
