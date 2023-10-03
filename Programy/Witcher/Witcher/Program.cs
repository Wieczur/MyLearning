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

            geralt.damageWitcher = 30;            
            geralt.cricitalStrikeDamageWticher = geralt.damageWitcher * 2;          
            geralt.cricitalChanceWitcher = 10; 
            
            drown1.healthPointDrown = 60;           
            drown1.damageDrown = 20;           
            drown1.cricitalStrikeDamageDrown = drown1.damageDrown * 2;           
            drown1.cricitalChanceDrown = 5;
            
            int roundNumber = 1;

            stats.PrintInitialStats(geralt.healthPointWitcherAfterCombat, geralt.damageWitcher, geralt.cricitalChanceWitcher, drown1.healthPointDrown, drown1.damageDrown, drown1.cricitalChanceDrown);

            while (geralt.healthPointWitcherAfterCombat > 0)
            {
                stats.PrintStatsBeforeRound(roundNumber);

                drown1.healthPointDrownAfterCombat = geralt.WitcherAction(geralt.healthPointWitcherAfterCombat, geralt.damageWitcher, healthPotion, geralt.cricitalStrikeDamageWticher, drown1.healthPointDrown);
                drown1.healthPointDrown = drown1.healthPointDrownAfterCombat;
               

                geralt.healthPointWitcherAfterCombat = drown1.DrownAction(drown1.healthPointDrown, drown1.damageDrown, drown1.cricitalStrikeDamageDrown, geralt.healthPointWitcherAfterCombat);
                drown1.healthPointDrown = drown1.healthPointDrownAfterCombat;
                

                stats.PrintStatsAfterRound(roundNumber, geralt.healthPointWitcherAfterCombat, drown1.healthPointDrown);

                roundNumber++;
            }
        }        
    }
}
