using System;
using System.Collections.Generic;
using System.Linq;
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
            int afterRound = 1;
            
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher = " + "healhPoint: " + healthPointWitcher + " , " + "Damage: " + damageWitcher + " , " + "CricitalStrike: " + cricitalChanceWitcher);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown = " + "healPoint: " + healthPointDrown + " , " + "Damage: " + damageDrown + " , " + "CricitalStrike: " + cricitalChanceDrown);
            Console.ResetColor();
            Console.ReadKey();


            while (healthPointWitcher > 0)
            {
                Console.WriteLine("* * * * * * * * * * * *");
                Console.WriteLine("Round: {0}", roundNumber);

                WitcherAction(healthPointWitcher, damageWitcher, healthPotion, cricitalStrikeDamageWticher, healthPointDrown, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                healthPointDrown = healthPointDrownAfterCombat;
                healthPointWitcher = healthPointWitcherAfterCombat;

                DrownAction(healthPointDrown, damageDrown, cricitalStrikeDamageDrown, healthPointWitcher, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                healthPointDrown = healthPointDrownAfterCombat;
                healthPointWitcher = healthPointWitcherAfterCombat;

                Console.ReadKey();
                roundNumber++;

                Console.WriteLine("After Round: {0}", afterRound);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Witcher = " + "healthPoint: " + healthPointWitcher);                             
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Drown = " + "healthPoint: " + healthPointDrown);
                Console.ResetColor();  
                Console.ReadKey();

                afterRound++;
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
                Random rnd = new Random();
                int randomNumber = (rnd.Next(1, 11));
                int sampleNumber = 5;
                if(randomNumber == sampleNumber)
                {
                    damageWitcher = cricitalStrikeDamageWticher;
                    Console.WriteLine("CricitalStrike: " + damageWitcher);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("WitcherAttack: " + damageWitcher);
                healthPointDrownAfterCombat = healthPointDrown - damageWitcher;                
                Console.ResetColor();
  
            }
            else if (healthPointWitcher < 30)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("UseHealPotion: " + healPotion);
                
                healthPointWitcherAfterCombat = healthPointWitcherAfterCombat + healPotion;
                Console.WriteLine("Witcher Health After Heal: " + healthPointWitcherAfterCombat);
                Console.ResetColor();
            }
            else if (healthPointWitcher == 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("WitcherDead");               
                Console.ResetColor();
                Console.ReadKey();
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
            //jaskolka
            int swallowHealPoints;
            int swallowHealPercentagePoints = 20;

            healthPointDrownAfterCombat = healthPointDrown;
            healthPointWitcherAfterCombat = healthPointWitcher;

            if (healthPointDrown > 0)
            {
                Random rnd = new Random();
                int randomNumber = (rnd.Next(1, 21));
                int sampleNumber = 5;
                if (randomNumber == sampleNumber)
                {
                    damageDrown = cricitalStrikeDamageDrown;
                    Console.WriteLine("CricitalStrike: " + damageDrown);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DrownAttack: " + damageDrown);
                healthPointWitcherAfterCombat = healthPointWitcher - damageDrown;
                Console.ResetColor();

            }           
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DrownDead");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Swallow Dropped");
                Console.WriteLine("Witcher use Swallow");
                Console.ResetColor();
                swallowHealPoints = swallowHealPercentagePoints * (MaxWitcherHealth - healthPointWitcherAfterCombat) / 100;
                healthPointWitcherAfterCombat = swallowHealPoints + healthPointWitcherAfterCombat;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Witcher HP after using Swallow = " + healthPointWitcherAfterCombat);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Next Drown Comming");
                Console.ResetColor();
                
                healthPointDrownAfterCombat = 60;

            }
   
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
