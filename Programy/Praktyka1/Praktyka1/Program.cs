using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktyka1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Wyswietl w konsoli prostokat o szerokosci x oraz wysokosci y
            // x oraz y podaje uzytkownik, prostokat zbudowany jest z "*"

            // Console.Write("Podaj szerokosc: ");
            // string xs = Console.ReadLine();
            // Console.Write("Podaj wysokosc: ");
            // string ys = Console.ReadLine();

            // int x = int.Parse(xs);
            // int y = int.Parse(ys);

            // for (int i = 0; i < y; i++)
            // {
            //     for (int j = 0; j < x; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();

            // }
            // Console.ReadKey();

            // gra w zgadywanie liczy wylosowanej przez komputer
            // komputer losuje liczbe z zakresu 1 - 10
            // uzytkownik probouje odgarnac wylosowana liczbe
            // jezeli podana liczba jest mniejsza lub wieksza od wylosowanej - wyswietl komunikat
            // kiedy uzytkownik odgadnie liczbe, wyswietl informacje o wygranej

            Random rnd = new Random();
            int los = (rnd.Next(1, 11));
            int mojaLiczba;
            int ileRazy = 0;

            Console.WriteLine("Zgadnij liczbe z zakresu od 1 do 10");
            do
            {
                Console.Write("Podaj Liczbe: ");
                mojaLiczba = int.Parse(Console.ReadLine());
                if (mojaLiczba > 10 || mojaLiczba < 1)
                {
                    Console.WriteLine("Podales liczbe z poza zakresu");
                }
                else
                {
                    ileRazy++;
                    if (mojaLiczba > los)
                    {
                        Console.WriteLine("Podales zbyt duza liczbe");
                    }
                    else if (mojaLiczba < los)
                    {
                        Console.WriteLine("Podales zbyt mala liczbe");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("BRAWO UDALO CI SIE! Za {0} razem", ileRazy);
                        Console.ResetColor();
                    }
                }
            } while (los != mojaLiczba);






        }

    }
}
