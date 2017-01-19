using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan arvo
            int vuosi;
            //kysytään vuotta
            Console.WriteLine("Anna vuosi");
            string line = Console.ReadLine();
            vuosi = int.Parse(line);

            //karkaus vuoden algoritmi 4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkaus vuosi");
            }

             else 
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi"); 
            }Console.ReadLine();
        }
    }
}
