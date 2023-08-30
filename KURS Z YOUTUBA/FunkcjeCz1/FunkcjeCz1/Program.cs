using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkcjeCz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dodaj(2,4, d:2);
            Console.ReadKey();
        }

        //static void Dodaj(int a, int b, int c = 0)
        //{
        //    int wynik = a + b + c;
        //    Console.WriteLine("Wynik dodawania: " + wynik);
        //}

        //static void Dodaj(int a, int b, int c)
        //{
        //    int wynik = a + b + c;
        //    Console.WriteLine("Wynik dodawania: " + wynik);
        //}

        static void Dodaj(int a, int b, int c = 2, int d = 0)
        {
            int wynik = a + b + c + d;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }

    }
}

// Fundament Programowania Obiektowego - nigdy nie powtarzaj tego co zrobiles wczesniej, nie marnuj czasu i nie pisz tego po raz kolejny !!!!!!!!!!!!!!!!!!!!!!!!! 
