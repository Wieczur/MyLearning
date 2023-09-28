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
        
        // Potion zycia
        const int healthPotion = 40;

        public static int MaxWitcherHealth { get; private set; }

        static void Main(string[] args)
        {
            ProgramStart();
        }

        static void ProgramStart()
        {
            var geralt = new Witcher();
            var drown1 = new Drown();
            

            Console.WriteLine(geralt.healthPoint);
            geralt.damageWitcher = 30;
            // Obrazenia Krytyczne Wiedzmina
            geralt.cricitalStrikeDamageWticher = geralt.damageWitcher * 2;
            // Szansa na obrazenia krytyczne
            geralt.cricitalChanceWitcher = 10;
            // Zycie Utopca
            drown1.healthPointDrown = 60;
            // Obrazenia Utopca
            drown1.damageDrown = 20;
            // Obrazenia Krytyczne Utopca
            drown1.cricitalStrikeDamageDrown = drown1.damageDrown * 2;
            // Szansa na obrazenia krytyczne
            drown1.cricitalChanceDrown = 5;
            // Liczba punktów życia po walce
            Console.WriteLine(drown1.healthPointDrownAfterCombat);
            Console.WriteLine(geralt.healthPointWitcherAfterCombat);


            // Runda
            int roundNumber = 1;


            PrintInitialStats(geralt.healthPoint, geralt.damageWitcher, geralt.cricitalChanceWitcher, drown1.healthPointDrown, drown1.damageDrown, drown1.cricitalChanceDrown);

            while (geralt.healthPoint > 0)
            {
                PrintStatsBeforeRound(roundNumber);
                
                WitcherAction(geralt.healthPoint, geralt.damageWitcher, healthPotion, geralt.cricitalStrikeDamageWticher, drown1.healthPointDrown, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                drown1.healthPointDrown = drown1.healthPointDrownAfterCombat;
                geralt.healthPoint = geralt.healthPointWitcherAfterCombat;

                DrownAction(drown1.healthPointDrown, drown1.damageDrown, drown1.cricitalStrikeDamageDrown, geralt.healthPoint, out healthPointDrownAfterCombat, out healthPointWitcherAfterCombat);
                drown1.healthPointDrown = drown1.healthPointDrownAfterCombat;
                geralt.healthPoint = geralt.healthPointWitcherAfterCombat;

                PrintStatsAfterRound(roundNumber, geralt.healthPoint, drown1.healthPointDrown);

                roundNumber++;
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
