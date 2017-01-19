using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //kysy pisteet
            int number;
            Console.Write("Anna pisteet ");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out number);
            if (result == true)
                switch (number)
                {
                    //vertailee annettua pistemäärää
                    case 0:
                    case 1: Console.WriteLine("Numeroksi tulee 0"); break;
                    case 2:
                    case 3: Console.WriteLine("Numeroksi tulee 1"); break;
                    case 4:
                    case 5: Console.WriteLine("Numeroksi tulee 2"); break;
                    case 6:
                    case 7: Console.WriteLine("Numeroksi tulee 3"); break;
                    case 8:
                    case 9: Console.WriteLine("Numeroksi tulee 4"); break;
                    case 10:
                    case 11:
                    case 12: Console.WriteLine("Numeroksi tulee 5"); break;
                } 
           Console.ReadLine();

        }
    }
}
