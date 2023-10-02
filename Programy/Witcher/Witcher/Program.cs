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
        // Potion zycia
        const int healthPotion = 40;

        static void Main(string[] args)
        {
            ProgramStart();
        }

        static void ProgramStart()
        {
            
            PrintStats stats = new PrintStats();
            Witcher geralt = new Witcher();
            Drown drown1 = new Drown();

           //Console.WriteLine(geralt.healthPoint);
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
            //Console.WriteLine("hp drown {0}", drown1.healthPointDrownAfterCombat);
            //Console.WriteLine("hp geralt {0}", geralt.healthPointWitcherAfterCombat);

            // Runda

            int roundNumber = 1;

            stats.PrintInitialStats(geralt.healthPoint, geralt.damageWitcher, geralt.cricitalChanceWitcher, drown1.healthPointDrown, drown1.damageDrown, drown1.cricitalChanceDrown);

            while (geralt.healthPoint > 0)
            {
                stats.PrintStatsBeforeRound(roundNumber);

                drown1.healthPointDrownAfterCombat = geralt.WitcherAction(geralt.healthPoint, geralt.damageWitcher, healthPotion, geralt.cricitalStrikeDamageWticher, drown1.healthPointDrown);
                drown1.healthPointDrown = drown1.healthPointDrownAfterCombat;
                geralt.healthPoint = geralt.healthPointWitcherAfterCombat;

                geralt.healthPointWitcherAfterCombat = drown1.DrownAction(drown1.healthPointDrown, drown1.damageDrown, drown1.cricitalStrikeDamageDrown, geralt.healthPoint);
                drown1.healthPointDrown = drown1.healthPointDrownAfterCombat;
                geralt.healthPoint = geralt.healthPointWitcherAfterCombat;

                stats.PrintStatsAfterRound(roundNumber, geralt.healthPoint, drown1.healthPointDrown);

                roundNumber++;
            }
        }        
    }
}
