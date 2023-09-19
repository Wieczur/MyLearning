using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            Console.WriteLine(adi.imie);
            adi.imie = "Bartek";
            Console.WriteLine(adi.imie);

            Czlowiek adi2 = new Czlowiek();
            Console.WriteLine(adi2.imie);

            adi.PrzedstawSie();

            Console.ReadKey();
        }
    }
    //class Czlowiek
    //{
    //    public string imie = "Adrian";
    //    public string nazwisko = "Kowalski";

    //    public void PrzedstawSie()
    //    {
    //        Console.WriteLine("Mam na imie " + imie);
    //    }
    //}
}
