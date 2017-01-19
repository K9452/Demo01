using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysy numero
            int number;
            Console.Write("Give a number ");
            string line = Console.ReadLine(); // "1"
            number = int.Parse(line); // "1" -> 1
            //mikä numero
            switch (number)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                default: Console.WriteLine("Give some other number"); break;
            }
            //jää odottamaan
            Console.ReadLine();
        }
    }
}
