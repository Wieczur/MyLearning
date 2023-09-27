using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WlasciwosciGetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();

            adi.imie = "Adrian";
            adi.Wiek = 20;
            
            Console.WriteLine($"Jestem {adi.imie} lat {adi.Wiek}.");
            Console.ReadKey();
        }
    }
}
