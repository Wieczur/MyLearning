using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiektyKonstruktor
{
    internal class Czlowiek
    {
        public Czlowiek()
        { 
        
        }
            
        public Czlowiek(string imieKonstruktora)
        {
            imie = imieKonstruktora;
        }
        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }
        public string imie = "BRAK";
        public string nazwisko = "BRAK";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imie " + imie);
        }

    }
}
