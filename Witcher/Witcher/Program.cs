using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // maksymalna ilosc zycia wiedzmina
            const int MaxWitcherHealth = 100;
            // Potion zycia
            const int healthPotion = 40;

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
            int damageDrown = 15;
            // Obrazenia Krytyczne Utopca
            int cricitalStrikeDamageDrown = damageDrown * 2;
            // Szansa na obrazenia krytyczne
            int cricitalChanceDrown = 5;
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
 
                Console.WriteLine("Round: {0}", roundNumber);
                healthPointDrown = WitcherAction(healthPointWitcher, damageWitcher, healthPotion, cricitalStrikeDamageWticher, healthPointDrown);
                DrownAction(healthPointDrown, damageDrown, cricitalStrikeDamageDrown, healthPointWitcher);
                Console.ReadKey();
                roundNumber++;

                Console.WriteLine("After Round: {0}", afterRound);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Witcher = " + "healhPoint: " + healthPointWitcher);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Drown = " + "healPoint: " + healthPointDrown);
                Console.ResetColor();
                Console.WriteLine("Next Drown Comming");
                Console.ReadKey();
                afterRound++;
            }
            

        }

        static int WitcherAction(int healthPointWitcher, int damageWitcher, int healPotion, int cricitalStrikeDamageWticher, int healthPointDrown)
        {
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
                healthPointDrown = healthPointDrown - damageWitcher;                
                Console.ResetColor();
  
            }
            else if (healthPointWitcher < 30)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("UseHealPotion: " + healPotion);               
                Console.ResetColor();
            }
            else if (healthPointWitcher == 0)
            {

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WitcherDead");               
                Console.ResetColor();
            }
            return healthPointDrown;
        }
        
        static int DrownAction(int healthPointDrown, int damageDrown, int cricitalStrikeDamageDrown, int healthPointWitcher)
        {
            if (healthPointDrown >= 30)
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
                healthPointWitcher = healthPointWitcher - damageDrown;
                Console.ResetColor();

            }           
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DrownDead");
                Console.ResetColor();
       
            }
            return healthPointWitcher;
            
            
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

