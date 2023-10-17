using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{

    internal class Witcher : Utils
    {
        public int damageWitcher { get; set; }
        public int cricitalStrikeDamageWticher { get; set; }
        public int cricitalChanceWitcher { get; set; }

        public Witcher()
        {
            healthPointWitcherAfterCombat = MaxWitcherHealth;
        }

        /// <summary>
        /// akcje wiedzmina
        /// </summary>
        /// <param name="healthPointWitcher">
        /// zycie wiedzmina
        /// </param>
        /// <param name="damageWitcher">
        /// obrazenia wiedzmina
        /// </param>
        /// <param name="healPotion">
        /// potka zycia
        /// </param>
        /// <param name="cricitalStrikeDamageWticher">
        /// obrazenia krytyczne wiedzmina
        /// </param>
        /// <param name="healthPointDrown">
        /// zycie utopca
        /// </param>
        /// <returns>
        /// metoda zwraca zycie utopca po rundzie
        /// </returns>
        public int WitcherAction(
            int healthPointWitcher,
            int damageWitcher,
            int healPotion,
            int cricitalStrikeDamageWticher,
            int healthPointDrown)
        {
            healthPointDrownAfterCombat = healthPointDrown;
            healthPointWitcherAfterCombat = healthPointWitcher;

            if (healthPointWitcher >= 30)
            {
                damageWitcher = CountCricitalStrikeWitcher(damageWitcher, cricitalStrikeDamageWticher);
                healthPointDrownAfterCombat = DealDamageAsAWitcher(damageWitcher, healthPointDrownAfterCombat, healthPointDrown);
            }
            else if (healthPointWitcher < 30)
            {
                healthPointWitcherAfterCombat = WitcherHealHimself(healPotion, healthPointWitcherAfterCombat);
            }
            else if (healthPointWitcher == 0)
            {
                WitcherDead();
            }
            return healthPointDrownAfterCombat;
        }

        static void WitcherDead()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Witcher Dead");
            Console.ResetColor();
            Console.ReadKey();
        }

        /// <summary>
        /// wiedzmin leczy sie za pomoca potki
        /// </summary>
        /// <param name="healPotion">
        /// potka zycia
        /// </param>
        /// <param name="healthPointWitcherAfterCombat">
        /// zycie wiedzmina po walce
        /// </param>
        /// <returns>
        /// metoda zwraca zycie wiedzmina po walce
        /// </returns>
        static int WitcherHealHimself(int healPotion, int healthPointWitcherAfterCombat)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Use heal potion: " + healPotion);

            healthPointWitcherAfterCombat = healthPointWitcherAfterCombat + healPotion;
            Console.WriteLine("Witcher health after heal: " + healthPointWitcherAfterCombat);
            Console.ResetColor();
            return healthPointWitcherAfterCombat;
        }

        /// <summary>
        /// metoda liczenia trafienia krytycznego przez wiedzmina
        /// </summary>
        /// <param name="damageWitcher">
        /// obrazenia wiedzmina
        /// </param>
        /// <param name="cricitalStrikeDamageWticher">
        /// obrazenia krytyczne wiedzmina
        /// </param>
        /// <returns>
        /// metoda zwraca obrazenia wiedzmina
        /// </returns>
        static int CountCricitalStrikeWitcher(int damageWitcher, int cricitalStrikeDamageWticher)
        {
            Random rnd = new Random();
            int randomNumber = (rnd.Next(1, 11));
            int sampleNumber = 5;

            if (randomNumber == sampleNumber)
            {
                damageWitcher = cricitalStrikeDamageWticher;
                Console.WriteLine("Cricital Strike: " + damageWitcher);
            }

            return damageWitcher;
        }

        /// <summary>
        /// zadawanie obrazen jako wiedzmin
        /// </summary>
        /// <param name="damageWitcher">
        /// obrazenia wiedzmina
        /// </param>
        /// <param name="healthPointDrownAfterCombat">
        /// punkty zycia utopca po walce
        /// </param>
        /// <param name="healthPointDrown">
        /// punkty zycia utopca
        /// </param>
        /// <returns>
        /// metoda zwraca punkty zycia utopca po walce
        /// </returns>
        static int DealDamageAsAWitcher(int damageWitcher, int healthPointDrownAfterCombat, int healthPointDrown)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher Attack: " + damageWitcher);
            healthPointDrownAfterCombat = healthPointDrown - damageWitcher;
            Console.ResetColor();

            return healthPointDrownAfterCombat;
        }
    }
}
