using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzydatneSlowaKluczowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Komentarz: namof - pozwala przekonwetowac nazwe zmiennej (nie jej wartosc) na stringa.

             var variable = 5;
             var nameOfVariable = nameof(variable);

            // Komentarz: typeof - sluzy do pobierania typu, jest to zmienna ktora powstaje po wykonaniu typeofa na jakims typie i jest zwracana wartosc typu ktora podamy.

            // var type = typeof(DateTime);
            // type.GetMethods();

            // Console.WriteLine(nameOfVariable);

            // Komentarz: default - sluzy do tego zeby miec vara xD co za wytlumaczenie :D

            var variable2 = default(int);
            if (true)
            {
                variable = 7;
            }
            else
            {
                variable = 3;
            }
            Console.WriteLine(variable);

            // Komentarz: Nazwy zmiennych z malej. Nazwy funkcji z duzej. Nazwy klas z duzej. Nazwy enumow z duzej. Nazwy stalych(const) z duzej.

        }
    }
}
