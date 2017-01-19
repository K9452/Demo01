using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan arvot sekuntti/tunti/minuutti
            int number, sekuntti, minuutti, tunti;
            Console.WriteLine("Anna sekunnit?");
            string line = Console.ReadLine();
            number = int.Parse(line);

            //tehdään ohjelma joka jakaa annetut sekunnit minuuteiksi ja minuutit tunniksi
            sekuntti = (number % 3600) % 60;
            minuutti = (number / 60) %60;
            tunti = (number / 3600) %60;
            

            //tulostetaan järjestyksessä tunnit/minuutit/sekunnit
            Console.WriteLine("Lopputulos " + tunti + " tuntia " + minuutti + " minuuttia " + sekuntti + " sekunttia "  );
            {
                Console.ReadLine();
            }
        }
    }
}
