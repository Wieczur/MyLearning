﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    internal class PrintStats
    {
        /// <summary>
        /// Metoda pokazuje Statystyki startowe
        /// </summary>
        /// <param name="healthPointWitcher">
        /// zycie wiedzmina
        /// </param>
        /// <param name="damageWitcher">
        /// obrazenia wiedzmina
        /// </param>
        /// <param name="cricitalChanceWitcher">
        /// szansa na trafienie krytyczne wiedzmina
        /// </param>
        /// <param name="healthPointDrown">
        /// zycie utopca
        /// </param>
        /// <param name="damageDrown">
        /// obraznia utopca
        /// </param>
        /// <param name="cricitalChanceDrown">
        /// szansa na  trafienie krytyczne przez utopca
        /// </param>
        public void PrintInitialStats(int healthPointWitcher, int damageWitcher, int cricitalChanceWitcher, int healthPointDrown, int damageDrown, int cricitalChanceDrown)
        {
            Console.WriteLine("Initial Stats");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher = " + "Life points: " + healthPointWitcher + " , " + "Damage: " + damageWitcher + " , " + "Cricital Strike: " + cricitalChanceWitcher);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown = " + "Life points: " + healthPointDrown + " , " + "Damage: " + damageDrown + " , " + "Cricital Strike: " + cricitalChanceDrown);
            Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// Metoda pokazuje statystyki przed runda
        /// </summary>
        /// <param name="roundNumber">
        /// numer rundy
        /// </param>
        public void PrintStatsBeforeRound(int roundNumber)
        {
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine("Round: {0}", roundNumber);
        }
        /// <summary>
        /// Metoda pokazuje statystyki po rundzie
        /// </summary>
        /// <param name="roundNumber">
        /// numer rundy
        /// </param>
        /// <param name="healthPointWitcher">
        /// zycie wiedzmina
        /// </param>
        /// <param name="healthPointDrown">
        /// zycie utopca
        /// </param>
        public void PrintStatsAfterRound(int roundNumber, int healthPointWitcher, int healthPointDrown)
        {
            Console.WriteLine("After Round: {0}", roundNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witcher = " + "Life points: " + healthPointWitcher);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Drown = " + "Life points: " + healthPointDrown);
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}
