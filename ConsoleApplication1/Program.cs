using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan lukujen arvot
            int luku1, luku2, luku3;
            //kysytään kolme eri lukua ja tallennetaan ne
            Console.WriteLine("Anna ensimmäinen numero ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);
            Console.WriteLine("Anna toinen numero ");
            line = Console.ReadLine();
            luku2 = int.Parse(line);
            Console.WriteLine("Anna kolmas numero ");
            line = Console.ReadLine();
            luku3 = int.Parse(line);
            //tulostus 
            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on " + luku1);
            }
            if (luku1 < luku2 && luku2 > luku3)
            { 
                Console.WriteLine("Suurin luku on " + luku2);
            }
            if (luku1 < luku3 && luku3 > luku2)
            {
                Console.WriteLine("Suurin luku on " + luku3);
            }
            Console.ReadLine();
        }
    }
}
