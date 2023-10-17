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

        /// <summary>
        /// Akcje Utopca
        /// </summary>
        /// <param name="healthPointDrown">
        /// zycie utopca
        /// </param>
        /// <param name="damageDrown">
        /// obraznia utopca
        /// </param>
        /// <param name="cricitalStrikeDamageDrown">
        /// obrazenia krytyczne
        /// </param>
        /// <param name="healthPointWitcher">
        /// zycie wiedzmina
        /// </param>
        /// <returns>
        /// metoda zwraca punkty zycia wiedzmina po walce
        /// </returns>
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
            Console.WriteLine("Drown Dead");
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        /// <summary>
        /// Obliczanie Obrazen krytycznych dla utopca
        /// </summary>
        /// <param name="damageDrown">
        /// obrazenia utopca
        /// </param>
        /// <param name="cricitalStrikeDamageDrown">
        /// obrazenia krytyczne utopca
        /// </param>
        /// <param name="healthPointWitcherAfterCombat">
        /// ilosc zycia wiedzmina po walce
        /// </param>
        /// <returns>
        /// metoda zwraca obraznia utopca
        /// </returns>
        int CountCricitalStrikeDrown(int damageDrown, int cricitalStrikeDamageDrown, int healthPointWitcherAfterCombat)
        {
            Random rnd = new Random();
            int randomNumber = (rnd.Next(1, 21));
            int sampleNumber = 5;

            if (randomNumber == sampleNumber)
            {
                damageDrown = cricitalStrikeDamageDrown;
                Console.WriteLine("Cricital Strike: " + damageDrown);
            }
            return damageDrown;
        }
        /// <summary>
        /// metoda zadaje obrazenia wiedzminowi
        /// </summary>
        /// <param name="healthPointWitcherAfterCombat">
        /// zycie wiedzina po walce
        /// </param>
        /// <param name="damageDrown">
        /// obrazenia utopca
        /// </param>
        /// <returns>
        /// metoda zwraca zycie wiedzmina po walce
        /// </returns>
        int DealDamageAsADrown(int healthPointWitcherAfterCombat, int damageDrown)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown Attack: " + damageDrown);
            healthPointWitcherAfterCombat = healthPointWitcherAfterCombat - damageDrown;
            Console.ResetColor();

            return healthPointWitcherAfterCombat;
        }

    }
}
