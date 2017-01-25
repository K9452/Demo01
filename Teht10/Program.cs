using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            //tehdään taulukko johon syötetään annetut numerot
            int[] Taulukko = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            // i on yht ku 0; i pienempi 9;i lisätään 2
            for (int i = 0; i < 9; i++)

            {
                //tehdään jako lasku eli jos luku on jaollienn kahdella
                if (Taulukko[i] % 2 == 0) 

                {
                    //tulostus
                    Console.WriteLine("HEP");
                   

                } Console.ReadLine();
            }
        }

    }
}
