using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Albumi
    {
        public string nimi;
        public string genre;
        public string artisti;

        // Yksityinen lista Kappale olioita, jota voidaan käsitellä vain tämän luokan sisällä

        private List<Kappale> kappaleet = new List<Kappale>();

        public Albumi(string nimi, string genre, string artisti)
        {
            this.nimi = nimi;
            this.genre = genre;
            this.artisti = artisti;
        }

        //Metodi jolla lisätään kappaleet listaan uusia kappaleita
        // Parametrinä kappale olio

        public void LisääKappale(Kappale uusiKappale)
        { 
            // lisätään listaan kappale parametrin arvosta
            kappaleet.Add(uusiKappale);
        }

        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi:");
            Console.WriteLine(" -Artisti: " + artisti);
            Console.WriteLine(" -Albumin nimi: " + nimi);
            Console.WriteLine(" -Genre: " + genre);
            Console.WriteLine("Songs:");


        foreach (Kappale kappale in kappaleet)
	    {
            kappale.TulostaTiedot();
	    }
        }
    }
}
