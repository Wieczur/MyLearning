using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class Utils
    {
        public int healthPointWitcherAfterCombat;
        public int MaxWitcherHealth = 100;
        public int healthPointDrownAfterCombat;

        /// <summary>
        /// metoda uzywania jaskolki przeez wiedzmina
        /// </summary>
        /// <param name="healthPointWitcherAfterCombat">
        /// zycie wiedzmina po walce
        /// </param>
        void WitcherUsingSwallow(int healthPointWitcherAfterCombat)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher HP after using Swallow = " + healthPointWitcherAfterCombat);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Next Drown Comming");
            Console.ResetColor();
        }
        /// <summary>
        /// metoda wypadania jaskolki
        /// </summary>
        /// <param name="swallowHealPercentagePoints">
        /// jaskolka leczy procentowa ilosc zycia
        /// </param>
        /// <param name="healthPointWitcherAfterCombat">
        /// zycie wiedzmina po walce
        /// </param>
        /// <returns>
        /// metoda zwraca zycie wiedzmina po walce
        /// </returns>
        public int SwallowDropped(int swallowHealPercentagePoints, int healthPointWitcherAfterCombat)
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
    }
}
