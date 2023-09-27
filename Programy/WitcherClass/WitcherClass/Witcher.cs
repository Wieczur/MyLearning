using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitcherClass
{
    internal class Witcher
    {
        public int Damage { get; set; }
        public int Health { get; set; }

        public void WitcherAction()
        {
            Console.WriteLine(Damage);
            Console.WriteLine(Health);
        }
    }
}
