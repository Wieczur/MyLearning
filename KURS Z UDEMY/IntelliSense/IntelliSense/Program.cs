using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IntelliSense
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            var List = new List<int>();
             var Dictionary = new Dictionary<int, string>();
              var date = new DateTime(2019, 10, 20, 15, 0, 0);

            date.ToLongDateString();

            Console.WriteLine(date.ToLongDateString());
        }
    }
}

// Komentarz:
// IntelliSense (Pojawia się po uzyciu kropki na dowolnej zmiennej),pokazuje wszystkie metody jakie mozemy wykonac na danej strukturze, zwalania nas z pamietania wszystkich metod, wszystkich funkcji
// w każdej chwili można z tego korzystać.
// struktury:
// - dictionary (Podobne do listy tylko zamiast jednego typu elementów, możemy używać pary elementów)
// - date (zapisywanie dat w kodzie)

