using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitcherWItchClasess
{
    public class Witcher
    {
        public Witcher()
        {
            

        }

        // maksymalna ilosc zycia wiedzmina
        const int MaxWitcherHealth = 100;
        // Hp Wiedzmina
        public int healthPointWitcher = MaxWitcherHealth;
        // Obrazenia Wiedzmina
        int damageWitcher { get; set; } = 30;

        // Obrazenia Krytyczne Wiedzmina
        int cricitalStrikeDamageWticher = damageWitcher * 2;
        // Szansa na obrazenia krytyczne
        int cricitalChanceWitcher = 10;
        // Liczba punktow zycia po walce
        int healthPointWitcherAfterCombat;

        public static void WitcherAction(
                int healthPointWitcher,
                int damageWitcher,
                int healPotion,
                int cricitalStrikeDamageWticher,
                int healthPointDrown,
                out int healthPointDrownAfterCombat,
                out int healthPointWitcherAfterCombat)
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
