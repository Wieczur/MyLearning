using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekPiwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CzyPijemy();
        }

        static void CzyPijemy()
        {
            Console.WriteLine("Marek czy pijesz piwo w sobotę?");
            Console.WriteLine("TAK LUB NIE");

            string Odpowiedz = Console.ReadLine();

            if (Odpowiedz.ToUpper() == "NIE")
            {
                Console.WriteLine("Spróbuj Ponownie");
                Console.ReadKey();
                CzyPijemy();

            }
            else if (Odpowiedz.ToUpper() == "TAK")
            {
                IlePijemy();
            }
            else
            {
                Console.WriteLine("Ogarnij się przewidziałem to hahahahahaha");
                Console.ReadKey();
                CzyPijemy();
            }
        }

        private static void IlePijemy()
        {
            Console.WriteLine("ILE?");
            int IlośćPiw;
            try
            {
                 IlośćPiw = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Program jest idiotoodporny");
                CzyPijemy();
                throw; 
            }

            if (IlośćPiw == 0)
            {

                Console.WriteLine("Chyba Cie pojebało");
                Console.ReadKey();
                CzyPijemy();
            }
            else if (IlośćPiw == 1)
            {
                Console.WriteLine("Dla jednego to mi sie z domu nie oplaca wychodzic");
                IlePijemy();
                

            }
            else if (IlośćPiw == 2)
            {
                Console.WriteLine("No juz lepiej ale mimo wszystko daj wiecej");
                IlePijemy();
            }
            else if (IlośćPiw > 0 && IlośćPiw <= 5)
            {
                Console.WriteLine("Namówiłeś");

                CzyMonikaPije();
            }
            else if (IlośćPiw > 5)
            {
                Console.WriteLine("Śmierci się nie boisz?");
                IlePijemy();
                
            }
            
        }

        private static void CzyMonikaPije()
        {
            Console.WriteLine("a co z Moniką pije? tak czy nie?");
            string Odpowiedz2 = Console.ReadLine();

            if (Odpowiedz2.ToLower() == "tak")
            {
                Console.WriteLine("wódkę?");
                string Odpowiedz3 = Console.ReadLine();

                if (Odpowiedz3.ToLower() == "tak")
                {
                    Console.WriteLine("no to lecimy");
                }
                else if (Odpowiedz3.ToLower() == "nie")
                {
                    Console.WriteLine("to i tak pijemy heheheh");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("przeciez wiedzialem, ze to sprawdzisz");
                    CzyMonikaPije();
                    Console.ReadKey();
                    
                }
            }
            else if (Odpowiedz2.ToLower() == "nie")
            {
                Console.WriteLine("to i tak pijemy heheheh");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("sprawdzasz mnie no nie ładnie nie ładnie");
                Console.ReadKey();
                CzyMonikaPije();
            }
        }
    }
}

