using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht9
{
    class Program
    {
        static void Main(string[] args)
        {
            //annetaan arvot, koskaei tiedetä monta niin pitää laittaa niin paljon ettei ainakaan lopu kesken, tehdään whilellä
            int AnnettuLuku = 1;
            int[] Luvut = new int[9999];
            int j = 0;
            int SummaLuku = 0;

            while (AnnettuLuku != 0)

            {
                //kyssäri
                Console.Write("Anna luku  ");

                AnnettuLuku = int.Parse(Console.ReadLine());
                Luvut[j] = AnnettuLuku;
                //j+2
                j++;
            }
            //jos i on yhtäk 0/ i on ismopi kuin j/lisätään 2 i
            for (int i = 0; i < j; i++)
            {
                SummaLuku = SummaLuku + Luvut[i];
            }

            Console.WriteLine("Lukujen summa on {0}", SummaLuku);
            {
                Console.ReadLine();
            }
        }
    }
}
