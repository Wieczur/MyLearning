using OPPDziedziczenie.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDziedziczenie
{
    class Program
    {
        public static IMenager GetMenager()
        {
            return new CloudMenager();
        }

        static void Main(string[] args)
        {

            var myLamp = new Lamp(200, 100);

            myLamp.LightItself();

            var myLamp2 = new Lamp(300, 150);

            myLamp2.LightItself();

            var menager = GetMenager();

            menager.SaveLamp(myLamp);

        }
    }
}

// dziedziczenie - rozszerzanie obecnej klasy o nowe rzeczy
// Interfejsy -  
// klasa moze dziedziczyc tylko po jednej klasie ale nieskonczenie wiele po interfejsach
