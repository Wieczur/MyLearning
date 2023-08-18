using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerowanieLosowychLiczb
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int a, b, r, g;
            Console.WriteLine("Podaj dolne ograniczenie:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj gorne ograniczenie:");
            b = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            r = rand.Next(a, b);
            Console.WriteLine("Zgadnij Liczbe");
            do
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (r != g)
                {
                    //Console.WriteLine(((r < g ? "za duza" : "za mala")));
                    if (r < g)
                    {
                        Console.WriteLine( "za duza");
                    }
                    else
                    {
                        Console.WriteLine(  "za mala");
                    }
                    //int foo
                    
                }
            } while (r != g);
            Console.WriteLine("Brawo zgadales liczbe");
            Console.ReadKey();
        

        
        }
    }
}
