using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            ziemia.RuchObrotowy();
            ziemia.PoraDniaINocy();
            ziemia.Atmosfera();
            
            Console.ReadKey();
        }
    }

    abstract class CialoNiebieskie
    {
        public string Nazwa { get; set; }
        public void RuchObrotowy()
        {
            Console.WriteLine("Kazde Cialo niebieskie posiada ruch obrotowy");
        }
    }
    abstract class Planeta : CialoNiebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory Dnia i Nocy");
        }
    }
    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera Ziemska");
        }

    }
    
}
