using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiektyKonstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            Console.WriteLine(adi.imie);
            adi.imie = "Bartek";
            adi.PrzedstawSie();

            Console.ReadKey();
        }
    }
}
