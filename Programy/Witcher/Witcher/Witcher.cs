using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{

    internal class Witcher
    {
        Drown drown1 = new Drown();

        public  int MaxWitcherHealth = 100;
        public int healthPoint {  get; set; }
        public int damageWitcher {  get; set; }
        public int cricitalStrikeDamageWticher { get; set; }
        public int cricitalChanceWitcher { get; set; }
        public int healthPointWitcherAfterCombat { get; set; }

        public Witcher()
        {
            healthPoint = MaxWitcherHealth;
        }

        public void WitcherStats()
        {
            Console.WriteLine(MaxWitcherHealth);
            Console.WriteLine(healthPoint);
            Console.WriteLine(damageWitcher);
            Console.WriteLine(cricitalStrikeDamageWticher);
            Console.WriteLine(cricitalChanceWitcher);
            Console.WriteLine(healthPointWitcherAfterCombat);

        }
        public void WitcherAction(
            int healthPointWitcher,
            int damageWitcher,
            int healPotion,
            int cricitalStrikeDamageWticher,
            int healthPointDrown)
        {
            drown1.healthPointDrownAfterCombat = healthPointDrown;
            healthPointWitcherAfterCombat = healthPointWitcher;

            if (healthPointWitcher >= 30)
            {
                damageWitcher = CountCricitalStrikeWitcher(damageWitcher, cricitalStrikeDamageWticher);
                drown1.healthPointDrownAfterCombat = DealDamageAsAWitcher(damageWitcher, drown1.healthPointDrownAfterCombat, healthPointDrown);
            }
            else if (healthPointWitcher < 30)
            {
                healthPointWitcherAfterCombat = WitcherHealHimself(healPotion, healthPointWitcherAfterCombat);
            }
            else if (healthPointWitcher == 0)
            {
                WitcherDead();
            }
        }

        static void WitcherDead()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("WitcherDead");
            Console.ResetColor();
            Console.ReadKey();
        }

        static int WitcherHealHimself(int healPotion, int healthPointWitcherAfterCombat)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("UseHealPotion: " + healPotion);

            healthPointWitcherAfterCombat = healthPointWitcherAfterCombat + healPotion;
            Console.WriteLine("Witcher Health After Heal: " + healthPointWitcherAfterCombat);
            Console.ResetColor();
            return healthPointWitcherAfterCombat;
        }

        static int CountCricitalStrikeWitcher(int damageWitcher, int cricitalStrikeDamageWticher)
        {
            Random rnd = new Random();
            int randomNumber = (rnd.Next(1, 11));
            int sampleNumber = 5;

            if (randomNumber == sampleNumber)
            {
                damageWitcher = cricitalStrikeDamageWticher;
                Console.WriteLine("CricitalStrike: " + damageWitcher);
            }

            return damageWitcher;
        }

        static int DealDamageAsAWitcher(int damageWitcher, int healthPointDrownAfterCombat, int healthPointDrown)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WitcherAttack: " + damageWitcher);
            healthPointDrownAfterCombat = healthPointDrown - damageWitcher;
            Console.ResetColor();

            return healthPointDrownAfterCombat;
        }


    }

}
