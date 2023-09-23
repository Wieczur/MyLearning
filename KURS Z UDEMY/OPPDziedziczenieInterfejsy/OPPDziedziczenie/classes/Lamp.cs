using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDziedziczenie
{
    internal class Lamp : Item
    {
        private int _power;
        
        public int Power
        {
            get
            {
                return _power;
            }
            private set
            {
                if (value <= 0)
                Console.WriteLine("Probowano ustawic nieprawdidlowa wartosc mocy lampy");
                return;
            } 
        }

        public void LightItself()
        {
            Console.WriteLine(Height);
            Console.WriteLine(Power);
        }

        public Lamp(int height, int power)
        {
            Height = height;
            Power = power;
        }
    }
}
