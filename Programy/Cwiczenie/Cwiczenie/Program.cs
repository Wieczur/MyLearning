using System;
using System.IO;

namespace Cwiczenie
{
    internal class Program
    {
        

        static void Main(string[] args)          
        {
            int counter = 0;
            var filePath = "C:\\Users\\Michau\\Desktop\\blebleble.txt";
            foreach (string line in File.ReadAllLines(filePath))
            {
                if (line.Contains("Ciebie"))
                {
                    counter++;
                    
                }
                
            }
            Console.WriteLine(counter);



        }
    }
}







//Wyszukaj plik tekstowy, nastepnie podaj ile razy w tekscie wystepuje slowo "Ciebie".

/* Co musisz zrobic Michal?
 * - zaladowac plik do visuala ktory bedzie Ci potrzebny.
 * - nastepnie musisz stworzyc funkcje ktora przeczyta linia po linii
 * - nastepnie musisz podac ifa ktory bedzie mial w argumencie (jesli w lini jest slowo Ciebie doda je oraz zworci jej ilosc)
*/