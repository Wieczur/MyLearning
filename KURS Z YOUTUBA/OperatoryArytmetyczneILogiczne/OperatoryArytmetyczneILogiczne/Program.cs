using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoryArytmetyczneILogiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatory logiczne:

            //bool a = 2 > 1;
            //bool b = 2 < 1;
            //bool c = 2 >= 1;
            //bool d = 2 <= 1;
            //bool e = 2 == 1;
            //bool f = 2 != 1; // != czy dwie zmiene sa od siebie rozne
            //bool g = !(2 == 2); // Nawias i wykrzynik z przodu jest negacja, operator jednoargumentowy.
            //bool a = 1 == 1 && 1 != 1; // koniunkcja logiczna && (I, AND)
            //bool b = 1 == 1 || 2 != 2; // || ( LUB, OR )
            //bool a = (true || true) && false;
            Math.Pow(2, 3); // Potegowanie
            Math.Sqrt(9); // Pierwiastek
            Math.Abs(9); // Wartosc bezwzgledna

            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Abs(9));
           //Console.WriteLine(b);
                                       

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //Console.WriteLine(g);


            /*
            int a = 2;
            int b = 3;
            int c;
            int c1;
            int c2;
            int c3;
            int c4;
            
            // operatory matematyczne:

            c = a + b;
            // c1 = a - b;
            // c2 = a * b;
            // c3 = a / b;
            // c4 = b % a;

            // Szybsze sposoby:
            a += b;
            a -= b;
            a /= b;
            a *= b;

            // Inkrementacja i dekrementacja:
            a++;
            a--;
            Console.WriteLine(a);
            Console.ReadKey();
            */
        }
    }
}
