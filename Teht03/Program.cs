using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan luvut
            int luku1, luku2, luku3;
          //kysyy kolmea lukua
            Console.Write("Anna ensimmäinen luku ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);
            Console.Write("Anna toinen luku ");
            line = Console.ReadLine();
            luku2 = int.Parse(line);
            Console.Write("Anna kolmas luku ");
            line = Console.ReadLine();
            luku3 = int.Parse(line);

            //laskee summan
            int summa;
            summa = (luku1 + luku2 + luku3);
            Console.WriteLine("Summa on :" + summa);
            //laskee keskiarvon
            int keskiarvo;
            keskiarvo = ((luku1 + luku2 + luku3) / 3);
            Console.WriteLine("Keskiarvo on :" + keskiarvo);
            {
                Console.ReadLine();
            }
        }
    }
}
