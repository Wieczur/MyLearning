using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Fiat", 1999);
            Auto auto2 = new Auto("Fiat", 1999);
            Console.WriteLine(auto1.Equals(auto2));
        }
    }
    class Auto
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Model = Model;
            this.Rocznik = Rocznik;
        }
        public bool Equals(Auto auto)
        {
            return auto.Model == this.Model && auto.Rocznik == this.Rocznik;
        }
    }
}
