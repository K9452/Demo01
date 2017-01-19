using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysy numero
            int number;
            Console.Write("Give a number ");
            string line = Console.ReadLine(); // "1"
            bool result = int.TryParse(line, out number);
            if (result == true)
            {
                //mikä numero
                switch (number)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    default: Console.WriteLine("Give some other number"); break;
                }
            } else
            {
                Console.WriteLine("Not a integer value!");
            }
            //jää odottamaan uutta enter lyöntiä
            Console.ReadLine();
        }
    }
}
