using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            //taulukko rakenne ja annetaan int 5 arvoa
            int[] Taulukko = new int[5];
            //loop tähän, jatkaa niin kauan kuin i on pienempi kuin 5 ja i:hin lisätään joka kierroksella 1
            for (int i = 0; i < 5; i++)

            {

                Console.Write("Anna luku  ");

                int Luku = int.Parse(Console.ReadLine());

                Taulukko[i] = Luku;

            }

            Console.Write("Luvut ovat ");
            //käänteis järjestys isommasta pienimpään
            for (int j = 4; j >= 0; j--)

            {
                //kirjoittaa taulukon luvun
                Console.Write(Taulukko[j]);
                //if lauseke, jos taulukko on suuremi kuin 1
                if (Taulukko[j] > 1)
                {
                    Console.Write(", ");
                }
            }
            Console.ReadLine();

        }
    }
}
