using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CwiczenieOdOli2
{
    internal class Program
    {
        public static int StartPos { get; private set; }

        static void Main(string[] args)
        {
            int StartPos;

            System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\Michau\\Desktop\\blebleble.txt");
            String Str = sr.ReadToEnd();

            int Count = 0;
            StartPos = 0;
            do
            {

                StartPos = Str.IndexOf("Ciebie ", StartPos);
                if (StartPos >= 0)
                {
                    StartPos++;
                    Count++;
                }
            }
            while (StartPos >= 0);

            Console.Write("File contained " + " " + Count + " " + "occurances");
            Console.ReadKey(true);




        }



        //foreach (var file in File.ReadAllLines(StreamReader sr);
        //{

        //    Console.WriteLine(file);

        // }




    }




    // foreach
    // 1. Stworz plik txt ktory bedzie zawierac 50 linii, napisz funkcje ktora otworzy ten plik, i na konsoli wyswietli jego zawartosc linia po linii.



    
}
