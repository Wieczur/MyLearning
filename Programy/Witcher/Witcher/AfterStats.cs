using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class AfterStats
    {
        static void PrintStatsAfterRound(int roundNumber, int healthPointWitcher, int healthPointDrown)
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
