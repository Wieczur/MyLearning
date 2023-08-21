using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetleWhileDoWhileFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PETLE | WHILE | FOR | DO WHILE

            // Petla While(dopoki)

            int a = 0;

            // while (a < 5)
            // {
            //    Console.WriteLine(a);
            //    Console.WriteLine("tekst");
            //    a++;
            // }

            /* w petli for zadeklarowana zmienna b, jest przypisana tylko w petli, po za nia nie istnieje, nie mamy do niej dostepu, jezeli chcesz miec do niej dostep
               zadeklaruj zmienna przed pettla for
            */

            // for (int b = 0 ; b < 5 ; b++) // kazda z czesci for jest opcjonalna moze byc a nie musi.
            // {
            //    Console.WriteLine(b);
            //    Console.WriteLine("tekst");
            // }

            do // Petla Do ma zagwarantowane to ze petla wykona sie co najmniej raz, co najmniej raz wykona instrukcje zawarte w klamrach
            {
                Console.WriteLine("tekst");
            }
            while (false);
            


            Console.ReadKey();
        }
    }
}
