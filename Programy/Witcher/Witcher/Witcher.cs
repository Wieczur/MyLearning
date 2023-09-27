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

        public const int MaxWitcherHealth = 100;
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

    }

}
