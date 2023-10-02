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
        public int healthPoint;

        void WitcherUsingSwallow(int healthPointWitcherAfterCombat)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher HP after using Swallow = " + healthPointWitcherAfterCombat);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Next Drown Comming");
            Console.ResetColor();
        }

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
