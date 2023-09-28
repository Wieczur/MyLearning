using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class BeforeStats
    {
       
        public void PrintStatsBeforeRound(int roundNumber)
        {
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine("Round: {0}", roundNumber);
        }
    }
}
