using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitcherClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Geralt = new Witcher();

            Geralt.Damage = 30;
            Geralt.Health = 100;
            Geralt.WitcherAction();

        }
    }
}
