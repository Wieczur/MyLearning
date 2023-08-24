using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeSkoku
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0;

        jeden:
            Console.WriteLine("Jeden");
            goto trzy;
        dwa:
            Console.WriteLine("Dwa");
        trzy:
            Console.WriteLine("Trzy");

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //while (true)
            //{
            //     //if(a > 10)
            //     //{
            //     //    break;
            //     //}
            //     //Console.WriteLine(a);
            //     //a++;
            //}

            Console.ReadKey();
        }
    }
}

// break = zlamac,wyskakujemy z petli po spelnionym warunku
// contiune = kontynuuj - ignoruje to co jest dalej w programie
// goto = idz do / ignoruje kod ponizej i przeskakuje do wybranej liniki