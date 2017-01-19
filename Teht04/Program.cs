using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            //anna ikä arvo
            int age;
            //kysy ikää
            Console.WriteLine("Tell me your age?");
            string line = Console.ReadLine();
            age = int.Parse(line);
            // tulostaa underaged/adult/senior
            if (age < 18)
            {
                Console.WriteLine("Undergaed");
            }
            
                if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Adult");
            }
            
                if (age > 65)
            {
                Console.WriteLine("Senior");
            }
            Console.ReadLine();

           
        }
    }
}
