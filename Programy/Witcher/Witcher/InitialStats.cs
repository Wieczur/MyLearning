using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class InitialStats
    {
       
        static void PrintInitialStats(int healthPointWitcher, int damageWitcher, int cricitalChanceWitcher, int healthPointDrown, int damageDrown, int cricitalChanceDrown)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher = " + "healhPoint: " + healthPointWitcher + " , " + "Damage: " + damageWitcher + " , " + "CricitalStrike: " + cricitalChanceWitcher);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown = " + "healPoint: " + healthPointDrown + " , " + "Damage: " + damageDrown + " , " + "CricitalStrike: " + cricitalChanceDrown);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
