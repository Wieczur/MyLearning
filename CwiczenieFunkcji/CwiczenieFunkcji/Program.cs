using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczenieFunkcji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dodaj(5, 10);
        }
        
        public static int Dodaj(string pierwsza, string druga)
        {
            if (int.TryParse(pierwsza, out int PierwszaInt))
            {
                return PierwszaInt;

            }
            else
            {

                return 0;

            }
            if (int.TryParse(druga, out int DrugaInt))
            {
                return DrugaInt;

            }
            else
            {

                return 0;

            }


            int wynik = PierwszaInt + DrugaInt;

            return wynik;

        }

        public static string Pomnoz(int pierwsza, int druga)
        {
            int Wynik = pierwsza * druga;
            string WynikString = Wynik.ToString();




            return WynikString;

        }


    }
}
