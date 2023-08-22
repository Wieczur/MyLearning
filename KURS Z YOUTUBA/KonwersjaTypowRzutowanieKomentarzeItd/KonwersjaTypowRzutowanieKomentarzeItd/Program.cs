using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonwersjaTypowRzutowanieKomentarzeItd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KOMENTARZE ( sa ignorowane przez program ) /* */ ( wielolinikowe )

            // SKROTY KLAWISZOWE & SNIPPETY
            /* (ctr + k, ctr + d) - program wraca do poprzedniej wersji, uklada kod na nowo
               (ctr + k, ctr + c) - wszystko co mielismy zaznaczone zmieni sie w komentarz
               (ctr + k, ctr + u) - odkomentowanie
               (cw + 2x tab)
               (for + 2x tab)
               (while + 2x tab)
            */


            // RZUTOWANIE ZMIENNYCH

            /* int i = int.MaxValue;
               short s = short.MaxValue;
               i = s;
               Console.WriteLine(i);
            */

            // int i = int.MaxValue;
            // short s = short.MaxValue;
            // s = (short)i; - do zmiennej typu int zostaje dopisana zmienna short tzw. rzutowanie
            // Console.WriteLine(i);

            // WCZYTYWANI DANYCH Z KONSOLI

            // string s = Console.ReadLine();
            // Console.WriteLine(s);
            // if (Console.ReadKey().Key == ConsoleKey.D1)
            //    Console.WriteLine("PRAWDA");

            // KONWERSJA TYPOW ( STRING > INT, INT < STRING )

            // string s = Console.ReadLine();
            // int i = int.Parse(s) + 2; // Parse moze przekonwertowac tylko liczby
            // Console.WriteLine(i);
            // s = i.ToString(); // ToString przekonwertuje liczby na tekst
            // Console.WriteLine(s);

            // LACZENIE TEKSTU & FORMATOWANIE "WRITELINE"

            string s1 = "Hello";
            string s2 = " World";
            string s3 = s1 + s2;
            //Console.WriteLine(s1 + s2 + "!!! {0}\n{1}",s1,s2);  // \n (nowa linia)

            // MODYFIKACJA WYGLADU KONSOLI

            //Console.WriteLine(s1 + s2 + "!!! {0}\n{1}", s1, s2);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine(s1 + s2 + "!!! {0}\n{1}", s1, s2);
            //Console.ResetColor();
            //Console.WriteLine(s1 + s2 + "!!! {0}\n{1}", s1, s2);

            //Console.ReadKey();
            //Console.Clear();
            //Console.ReadKey();

            
        }
        
    }
}
