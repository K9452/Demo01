using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan arvojennimet ja tehdään ensimmäinen kysymys
            int matka;
            double kulutus, hinta;
            Console.WriteLine("Anna matka km");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            //algoritmi joka laskee kulutuksen annetun matkan perusteella(7,02l/100km)

            kulutus = (matka / 100) * 7.02;

            //algoritmi joka laskee kulutuksen perusteella kertyvän bensan hinnan

            hinta = (kulutus * 1.595);

            Console.WriteLine("Bensaa kuluu " + kulutus + " litraa, " + "kustannus " + hinta + " euroa");


            {
                Console.ReadLine();
            }
        }
    }
}
