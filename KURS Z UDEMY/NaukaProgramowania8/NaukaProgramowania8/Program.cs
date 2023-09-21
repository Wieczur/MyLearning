using System;

namespace NaukaProgramowania8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liczba = 5;
            Console.WriteLine(liczba);
            Console.WriteLine(Podwojliczbe(liczba));
            Console.WriteLine(liczba);
            Console.WriteLine(Podwojliczbe1(out liczba));
            Console.WriteLine(liczba);
        }
        
        private static int Podwojliczbe(int liczba1)
        {

            return liczba1 * 2;
        }

        private static int Podwojliczbe1(out int liczba1)
        {
            liczba1 = 2;
            return liczba1 * 2;
        }


        private static int PrzekonwertujDoublaNaInta(double liczba)
        {
            if (int.TryParse(liczba.ToString(), out int liczba2))
            {

                return liczba2;
            } 
            else
            {

                return 0;
            }
                
        }
           
     
    }
}

/* Komentarz:
 * Parsowanie Rzutowanie ( pomaga zmienic jeden typ na drugi )
 * usuwanie niepotrzebnych usingow ctr + R + G
 * Parsowanie jest nowoczesne
 */