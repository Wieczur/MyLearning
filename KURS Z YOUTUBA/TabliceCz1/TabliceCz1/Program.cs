using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceCz1
{
    internal class Program
    {
        static void Main(string[] args)
        // TABLICE - to zbiór wiekszej ilosci danych tego samego typu, ktore kryja sie pod jedna nazwa ale pod innymi komórkami.
        // tablica ma z góry okreslony rozmiar, [] nie może pozostac pusty.
        // PAMIETAJ BARANIE ZE 0 JEST PIERWSZYM ELEMENTEM W PROGRAMOWANIU !
        // Indeksow mamy jeden mniej niz tablicy.
        // Do tablicy czesto uzywana jest petla, ktora ma za zadanie skrocic kod, a nie rozpisywac kod na wiele linii.
        // Tablica jest nierozszerzalna to jest jej wada, przydaje sie w okreslonym typie zadan ktore chcemy wykonac, nie mozemy jej zwiekszyc ani zmniejszyc.
        // Jezeli z gory wiemy jaka zadeklarujemy wartosc, wtedy stosujemy tablice do naszych zmiennych.


        {
            int[] tablica = new int[365];
            string[] dniTygodnia = { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
            //tablica[0] = 22;
            //tablica[364] = 23;
            //Console.WriteLine(tablica[364]);

            for (int i = 0; i < dniTygodnia.Length; i++) 
            {
                Console.WriteLine(dniTygodnia[i]);
            }

            Console.ReadKey();


            
        }
    }
}
