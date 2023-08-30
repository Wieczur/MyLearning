using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FunkcjeCz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(2, 4));      
            Console.ReadKey();
        }

        //static int Dodaj(int a, int b)
        //{
        //    int wynik = a + b;
        //    return wynik;
        //}
       
        //static int Dodaj(int a, int b)
        //{
        //    int wynik = a + b;
        //    if(wynik >= 10)
        //    {
        //        return wynik;
        //    }
        //    else
        //    {
        //        return wynik;
        //    }
        //}

        static string Dodaj(int a, int b)
        {
            int wynik = a + b;
            if (wynik >= 10)
            {
                return "wynik wiekszy od 10";
            }
            else
            {
                return "wynik mniejszy od 10";
            }
        }
    }
}

