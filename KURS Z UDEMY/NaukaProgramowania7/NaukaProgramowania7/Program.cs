using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaProgramowania7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liczba = 8;
            NazwaFunkcji();
            var liczba2 = Podwojliczbe(liczba);
            Console.WriteLine(liczba2);
        }

        private static void NazwaFunkcji()
        {
            Console.WriteLine(5);
           
        }


        private static int  Podwojliczbe(int liczba1)
        {

            return liczba1 * 2;
        }
    }
}

/* Komentarz:
 * Funkcje najczesciej uzywane po zmiennych
 * Funkcja sklada sie z Nazwy funkcji wywolujemy ja przez nawiasy na koncu w srodku nawiasu sa argumenty ale tez moze byc pusta bez argumentow
 * void ( typ funkcji ktora nie zwraca swojej wartosci )
 * private static jest zwiazane z Programowaniem Obiektowym ktore bedzie pozniej
 */