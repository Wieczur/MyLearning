using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitcherWItchClasess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Witcher Geralt = new Witcher();
            
            
            // Runda
            int roundNumber = 1;



            PrintInitialStats(healthPointWitcher, damageWitcher, cricitalChanceWitcher, healthPointDrown, damageDrown, cricitalChanceDrown);

            while (Witcher.healthPointWitcher > 0)
            {
                PrintStatsBeforeRound(roundNumber);

                Witcher.WitcherAction(healthPointWitcher, damageWitcher, healthPotion, cricitalStrikeDamageWticher, healthPointDrown, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                healthPointDrown = healthPointDrownAfterCombat;
                healthPointWitcher = healthPointWitcherAfterCombat;

                DrownAction(healthPointDrown, damageDrown, cricitalStrikeDamageDrown, healthPointWitcher, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                healthPointDrown = healthPointDrownAfterCombat;
                healthPointWitcher = healthPointWitcherAfterCombat;

                PrintStatsAfterRound(roundNumber, healthPointWitcher, healthPointDrown);

                roundNumber++;
            }
        }
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

        static void PrintStatsBeforeRound(int roundNumber)
        {
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine("Round: {0}", roundNumber);
        }

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
