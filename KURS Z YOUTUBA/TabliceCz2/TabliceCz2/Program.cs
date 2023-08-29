using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceCz2
{
    internal class Program
    {
        static void Main(string[] args)
        //Tablice Wielowymiarowe
        //wymiary oddzielamy przecinkiem
        //dodajac przecinki dodajemy wymiar
        //tworzy sie tablice wymiarowe na 2 wymiary max 3 poniewaz wieksza ilosc Tworzy chaos ktory lepiej rozpisac w inny sposob
        {
            //int[,] tab = new int[2, 3];
            //tab[0, 0] = 1;
            //tab[0, 1] = 2;
            //tab[0, 2] = 3;
            //tab[1, 0] = 10;
            //tab[1, 1] = 22;
            //tab[1, 2] = 33;

            //for (int i = 0; i < tab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tab.GetLength(1); j++)
            //    {
            //        Console.Write(tab[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //TABLICE TABLIC

            //int[][] tab = new int[2][];
            //tab[0] = new int[3];
            //tab[1] = new int[2];
            //tab[0][0] = 2;
            //tab[0][1] = 3;
            //tab[0][2] = 5;
            //tab[1][0] = 12;
            //tab[1][1] = 43;

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    for (int j = 0; j < tab[i].Length; j++)
            //    {
            //        Console.Write(tab[i][j] + " " );
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            int[] tab = new int[4];

            tab[0] = 5;
            tab[1] = 4;
            tab[2] = 10;
            tab[3] = 1;

            //Console.WriteLine(tab.Sum());
        
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine();

            Array.Sort(tab);
            for (int i = 0;i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine();

            Array.Reverse(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();



        }
    }
}
