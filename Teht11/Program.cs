using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan roundille arvo
            int round = 1;
            //Kysytään käyttäjältä numeroa
            Console.WriteLine("Anna luku  ");
            int Luku = int.Parse(Console.ReadLine());
            //ensimmäinen silmukka
            for (int i = 1; i <= Luku; i++)

            {
                //saadaan tupla silmukka
                for (int j = 1; j <= round; j++)

                {
                    //tähti tulostus
                    Console.Write("*");

                }
                //tyhjä
                Console.WriteLine("");
              //lisätään
                round++;
            }Console.ReadLine();
        }
    }
}
