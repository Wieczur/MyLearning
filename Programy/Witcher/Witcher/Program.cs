using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Witcher
{
    internal class Program
    {
        // maksymalna ilosc zycia wiedzmina
        const int MaxWitcherHealth = 100;
        // Potion zycia
        const int healthPotion = 40;

        static void Main(string[] args)
        {
            ProgramStart();
        }
        static void ProgramStart()
        {
            
            // Hp Wiedzmina
            int healthPointWitcher = MaxWitcherHealth;
            // Obrazenia Wiedzmina
            int damageWitcher = 30;
            // Obrazenia Krytyczne Wiedzmina
            int cricitalStrikeDamageWticher = damageWitcher * 2;
            // Szansa na obrazenia krytyczne
            int cricitalChanceWitcher = 10;
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
            int healthPointWitcherAfterCombat;
            // Runda
            int roundNumber = 1;
            
            PrintInitialStats(healthPointWitcher, damageWitcher, cricitalChanceWitcher, healthPointDrown, damageDrown, cricitalChanceDrown);

            while (healthPointWitcher > 0)
            {
                PrintStatsBeforeRound(roundNumber);
                
                WitcherAction(healthPointWitcher, damageWitcher, healthPotion, cricitalStrikeDamageWticher, healthPointDrown, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                healthPointDrown = healthPointDrownAfterCombat;
                healthPointWitcher = healthPointWitcherAfterCombat;

                DrownAction(healthPointDrown, damageDrown, cricitalStrikeDamageDrown, healthPointWitcher, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                healthPointDrown = healthPointDrownAfterCombat;
                healthPointWitcher = healthPointWitcherAfterCombat;

                PrintStatsAfterRound(roundNumber, healthPointWitcher, healthPointDrown);

                roundNumber++;
            }
        }

        static void WitcherAction(
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
       
        static void WitcherUsingSwallow(int healthPointWitcherAfterCombat)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher HP after using Swallow = " + healthPointWitcherAfterCombat);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Next Drown Comming");
            Console.ResetColor();
        }

        static int SwallowDropped(int swallowHealPercentagePoints, int healthPointWitcherAfterCombat)
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

/*
 
   wiedźmin walczy dopóki ma hp>0
   ma określone dmg i hp i napierdala sie z utopcem
   ma prosty ekwipunek, tylko potiony na zycie liczone w integerze
   w kazdej turze może walić mieczem albo sie leczyć
   utopiec wali zawsze

   każde walnięcie ma procent szansy na trafienie, wiedzmin ma wieksze niz utopiec, dmg i hp tez ma wieksze

   po zabiciu utopca wypada jaskółka i wchodzi nastepny utopiec i tak do zasranej śmierci
*/

// kiedy uzywasz jaskolki? jaskolki uzywasz od razu po zabiciu utopca, ma za zadanie przywrocic procentowa ilosc zycia, procent oblicza sie z brakujacego zycia, po zabiciu utopca.
// stworz czmepiona ktory bedzie mocniejszy od zwyklego utopca, bedzie mial wiecej zycia, zadawal wiecej obrazen, i bedzie mial szanse na stuna
