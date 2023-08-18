using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Threading;
using System.Xml.Schema;

namespace ZadanieOdAleksandyBurkiewiczMentorki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Liczba;
            int Liczba2;
            int IloscLiczb = 2;
            
            var Lista = new List<int>();

            for (int i = 0; i < IloscLiczb; i++)                
            {
                do
                {
                    Liczba2 = int.Parse(Console.ReadLine());

                    SprawdzPodzielnosc(Liczba2, 3);
                    SprawdzPodzielnosc(Liczba2, 5);
                    SprawdzPodzielnosc(Liczba2, 15);

                } while (Liczba2 <= 0);

                Lista.Add(Liczba2);            
            }

            
            int total = Lista.Sum();
            Console.WriteLine("Suma: {0}", total);

            double srednia = WyliczSrednia(total, IloscLiczb);
            Console.WriteLine("srednia: {0}", srednia);

            CzyJestMniejszaWieksza(Lista);
        }

        private static bool CzyJestMniejszaWieksza(List<int> lista)
        {
            if (lista[0] > lista[1])
            {             
                Console.WriteLine("{0} Jest Wieksza od {1}" , lista[0] , lista[1]);
                return true;
            }
            else
            {
                Console.WriteLine("{0] Jest Mniejsza od {1}", lista[0], lista[1]);
                return false;          
            }
        }

        private static void SprawdzPodzielnosc(int liczba2, int Podzielnosc)
        {
            if (liczba2 % Podzielnosc == 0)
            {
                Console.WriteLine("Podana liczba jest podzielna przez {0} ", Podzielnosc);
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest podzielna przez {0} ", Podzielnosc);
            }
        }

        private static double WyliczSrednia(int suma, int IloscDanych)
        {
            double srednia = suma / IloscDanych;
            return srednia;
        }
    }
}


/* Komentarz: Rozjebałem mózg informatykowi hahahahahahahahha
 */

// komentarz od Oli: zobaczymy jak rozjebiesz mi mózg dziś :)

//Dziś będziesz ćwiczył funkcje (metody) - nazwy używam zamiennie. 
//   Proszę o stworzenie metody, która będzie wywołana w linii 33 o nazwie WyliczSrednia (zamiast linii int srednia = total / 2; - przykra wiadomość, to będzie do usunięcia)
//   ktora jako argument przyjmie int suma oraz int iloscDanych, a zwróci wartość średnią, jako typ double - z dokładnością do 2 miejsc po przecinku (użyj google).
// W Main wywołaj tą metodę, a to co zwróci, wyświetl na konsoli z ładnym komentarzem.

/* Wynik :
   Ola : 2,5
   Michał : 1,5
*/


//do każdej z wczytanych zmiennych w pętli for (linia 17) określ, czy liczba jest parzysta, czy nie i opisz to odpowiednim komentarzem na konsoli.
//Do tego celuj potrzebujesz poznać funkcję mod(modulo) - szukaj tego w google, liczba musi byc podzielna przez dwa
//Okresl czy liczba jest podzielna przez 3,5 i 15.

