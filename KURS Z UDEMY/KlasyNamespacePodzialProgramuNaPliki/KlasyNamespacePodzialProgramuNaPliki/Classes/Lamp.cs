using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyNamespacePodzialProgramuNaPliki
{
    internal class Lamp
    {

        private int Height { get; set; }
        private int Power { get; set; }

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

// Konstruktor musi byc zawsze public