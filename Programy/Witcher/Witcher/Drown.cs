using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class Drown : Utils
    {

        public int healthPointDrown { get; set; }
        public int damageDrown { get; set; }
        public int cricitalStrikeDamageDrown { get; set; }
        public int cricitalChanceDrown { get; set; }

        public void DrownStats()
        {
            Console.WriteLine(healthPointDrown);
            Console.WriteLine(damageDrown);
            Console.WriteLine(cricitalStrikeDamageDrown);
            Console.WriteLine(cricitalChanceDrown);
            Console.WriteLine(healthPointDrownAfterCombat);

        }
        public int DrownAction(
            int healthPointDrown,
            int damageDrown,
            int cricitalStrikeDamageDrown,
            int healthPointWitcher)
        {
            int swallowHealPercentagePoints = 20;

            healthPointDrownAfterCombat = healthPointDrown;
            healthPointWitcherAfterCombat = healthPointWitcher;

            if (healthPointDrown > 0)
            {
                damageDrown = CountCricitalStrikeDrown(damageDrown, cricitalStrikeDamageDrown, healthPointWitcherAfterCombat);
                healthPointWitcherAfterCombat = DealDamageAsADrown(healthPointWitcherAfterCombat, damageDrown);
            }
            else
            {
                DrownDead();

                healthPointWitcherAfterCombat = SwallowDropped(swallowHealPercentagePoints, healthPointWitcherAfterCombat);

                healthPointDrownAfterCombat = 60;
            }
            return healthPointWitcherAfterCombat;
        }

        void DrownDead()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DrownDead");
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        int CountCricitalStrikeDrown(int damageDrown, int cricitalStrikeDamageDrown, int healthPointWitcherAfterCombat)
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

        int DealDamageAsADrown(int healthPointWitcherAfterCombat, int damageDrown)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DrownAttack: " + damageDrown);
            healthPointWitcherAfterCombat = healthPoint - damageDrown;
            Console.ResetColor();

            return healthPointWitcherAfterCombat;
        }

    }
}
