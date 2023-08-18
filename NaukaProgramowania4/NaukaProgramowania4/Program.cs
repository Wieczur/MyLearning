using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaProgramowania4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var liczba1 = int.Parse (Console.ReadLine());
            var liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 > liczba2)
            {
                Console.WriteLine("liczba1 jest wieksza");

            }

            if (liczba1 < liczba2)
            {
                Console.WriteLine("liczba1 jest mniejsza");

            }
            if (liczba1 == liczba2)
            {
                Console.WriteLine("liczba1 jest rowna liczbie dwa");

            }








        }
    }
}

          /* Komentarz:
           * Decyzje w programie ( IF ) możemy wpisać wartość prawda albo fałsz które powodują to, czy program wykona zadanie czy go nie wykona.
           * dajemy klamerki pod ifem co obejmuje kod który znajduję się pod tym warunkiem
           * operacja else jest zawsze po ifie nie ma nawiasów, else wykona się tylko jeżeli bool jest falsem
           * w nawiasy nie trzeba wpisywać zmiennej tylko do razu wartość
           * operacje ( > ), ( >= ), ( <= ), ( == ) 
           * Console.Readline ( Pisanie w Konsoli )
           */