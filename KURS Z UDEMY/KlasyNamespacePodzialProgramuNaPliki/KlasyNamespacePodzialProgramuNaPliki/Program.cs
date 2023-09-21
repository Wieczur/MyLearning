using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyNamespacePodzialProgramuNaPliki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myLamp = new Lamp(200, 100);

            myLamp.LightItself();

            var myLamp2 = new Lamp(300, 150);

            myLamp2.LightItself();

        }
    }
}
