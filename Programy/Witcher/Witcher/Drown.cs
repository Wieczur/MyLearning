using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class Drown
    {
       
        public int healthPointDrown { get; set; }
        public int damageDrown { get; set; }
        public int cricitalStrikeDamageDrown { get; set; }
        public int cricitalChanceDrown { get; set; }
        public int healthPointDrownAfterCombat { get; set; }

        public void DrownStats()
        {
            Console.WriteLine(healthPointDrown);
            Console.WriteLine(damageDrown);
            Console.WriteLine(cricitalStrikeDamageDrown);
            Console.WriteLine(cricitalChanceDrown);
            Console.WriteLine(healthPointDrownAfterCombat);
 
        }
        static void DrownAction(
            int healthPointDrown,
            int damageDrown,
            int cricitalStrikeDamageDrown,
            int healthPointWitcher,
            out int healthPointDrownAfterCombat,
            out int healthPointWitcherAfterCombat)
        {
            int swallowHealPercentagePoints = 20;

            healthPointDrownAfterCombat = healthPointDrown;
            healthPointWitcherAfterCombat = healthPointWitcher;

            if (healthPointDrown > 0)
            {
                damageDrown = CountCricitalStrikeDrown(damageDrown, cricitalStrikeDamageDrown, healthPointWitcherAfterCombat, healthPointWitcher);
                healthPointWitcherAfterCombat = DealDamageAsADrown(healthPointWitcherAfterCombat, damageDrown, healthPointWitcher);
            }
            else
            {
                DrownDead();

                healthPointWitcherAfterCombat = SwallowDropped(swallowHealPercentagePoints, healthPointWitcherAfterCombat);

                healthPointDrownAfterCombat = 60;
            }
             void WitcherUsingSwallow(int healthPointWitcherAfterCombat)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Witcher HP after using Swallow = " + healthPointWitcherAfterCombat);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Next Drown Comming");
                Console.ResetColor();
            }

            int SwallowDropped(int swallowHealPercentagePoints, int healthPointWitcherAfterCombat)
            {
                int swallowHealPoints;

                Console.WriteLine("Swallow Dropped");
                Console.WriteLine("Witcher use Swallow");
                Console.ResetColor();
                swallowHealPoints = swallowHealPercentagePoints * (MaxWitcherHealth - healthPointWitcherAfterCombat) / 100;
                healthPointWitcherAfterCombat = swallowHealPoints + healthPointWitcherAfterCombat;

                WitcherUsingSwallow(healthPointWitcherAfterCombat);
                return healthPointWitcherAfterCombat;
            }

            void DrownDead()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DrownDead");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            int CountCricitalStrikeDrown( int damageDrown, int cricitalStrikeDamageDrown, int healthPointWitcherAfterCombat, int healthPointWitcher)
            {
                Random rnd = new Random();
                int randomNumber = (rnd.Next(1, 21));
                int sampleNumber = 5;

                if (randomNumber == sampleNumber)
                {
                    damageDrown = cricitalStrikeDamageDrown;
                    Console.WriteLine("CricitalStrike: " + damageDrown);
                }
                return damageDrown;
            }
            int DealDamageAsADrown(int healthPointWitcherAfterCombat, int damageDrown, int healthPointWitcher)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DrownAttack: " + damageDrown);
                healthPointWitcherAfterCombat = healthPointWitcher - damageDrown;
                Console.ResetColor();

                return healthPointWitcherAfterCombat;
            }
        }
    }
}
