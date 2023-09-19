using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiekty
{
    class Czlowiek
    {
        public string imie = "Adrian";
        public string nazwisko = "Kowalski";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imie " + imie);
        }
    }
}
