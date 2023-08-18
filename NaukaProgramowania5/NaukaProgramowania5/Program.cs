using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaProgramowania5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lista = new List<int>();

            lista.Add(int.Parse(Console.ReadLine()));
            lista.Add(int.Parse(Console.ReadLine()));

            if (lista[0] > lista[1])
            {
                Console.WriteLine("liczba1 jest wieksza");

            }

            if (lista[0] < lista[1])
            {
                Console.WriteLine("liczba1 jest mniejsza");

            }
            if (lista[0] == lista[1])
            {
                Console.WriteLine("liczba1 jest rowna liczbie dwa");

            }




        }
    }
}

/* Komentarz: Tworzenie list ( przechowywanie dużej liczby danych ) 
 */