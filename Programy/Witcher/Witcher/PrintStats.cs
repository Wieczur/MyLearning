using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class PrintStats
    {

        public void PrintInitialStats(int healthPointWitcher, int damageWitcher, int cricitalChanceWitcher, int healthPointDrown, int damageDrown, int cricitalChanceDrown)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher = " + "healhPoint: " + healthPointWitcher + " , " + "Damage: " + damageWitcher + " , " + "CricitalStrike: " + cricitalChanceWitcher);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown = " + "healPoint: " + healthPointDrown + " , " + "Damage: " + damageDrown + " , " + "CricitalStrike: " + cricitalChanceDrown);
            Console.ResetColor();
            Console.ReadKey();
        }

        public void PrintStatsBeforeRound(int roundNumber)
        {
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine("Round: {0}", roundNumber);
        }
        public void PrintStatsAfterRound(int roundNumber, int healthPointWitcher, int healthPointDrown)
        {
            Console.WriteLine("After Round: {0}", roundNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher = " + "healthPoint: " + healthPointWitcher);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown = " + "healthPoint: " + healthPointDrown);
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}
