using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myLamp = new Lamp();

            myLamp.Height = 200;
            myLamp.Power = 100;

            myLamp.LightItself();

            var myLamp2 = new Lamp();
            myLamp2.Height = 300;
            myLamp2.Power = 150;

            myLamp2.LightItself();

        }
    }
   
}

// public - funkcje ktora mozna wykorzystac po za klasa
// static - fukncje mozna wykorzystac bez obiektu
