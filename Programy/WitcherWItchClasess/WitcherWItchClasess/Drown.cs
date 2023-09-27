using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitcherWItchClasess
{
    internal class Drown
    {
        // Zycie Utopca
        int healthPointDrown = 60;
        // Obrazenia Utopca
        int damageDrown = 20;
        // Obrazenia Krytyczne Utopca
        int cricitalStrikeDamageDrown = damageDrown * 2;
        // Szansa na obrazenia krytyczne
        int cricitalChanceDrown = 5;
        // Liczba punktów życia po walce
        int healthPointDrownAfterCombat;
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
        }
        static void DrownDead()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DrownDead");
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        static int CountCricitalStrikeDrown(int damageDrown, int cricitalStrikeDamageDrown, int healthPointWitcherAfterCombat, int healthPointWitcher)
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
        static int DealDamageAsADrown(int healthPointWitcherAfterCombat, int damageDrown, int healthPointWitcher)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DrownAttack: " + damageDrown);
            healthPointWitcherAfterCombat = healthPointWitcher - damageDrown;
            Console.ResetColor();

            return healthPointWitcherAfterCombat;
        }
    }
}