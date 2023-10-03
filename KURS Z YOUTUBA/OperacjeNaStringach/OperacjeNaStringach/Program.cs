using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OperacjeNaStringach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string tekst = "Tekst";
            //string tekst2 = "Tekst";
            //string wynik = tekst + tekst2;
            //Console.WriteLine(wynik);
            //Console.ReadKey();

            Stopwatch stopwatch = new Stopwatch();           
            int ile = 10000;
            stopwatch.Start();
            budujString(ile);
            stopwatch.Stop();
            Console.WriteLine("Standardowa metoda: {0} ms", stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();
            stopwatch.Start();
            BudujStringBuilder(ile);
            stopwatch.Stop();
            Console.WriteLine("Metoda StringBuilder: {0} ms", stopwatch.ElapsedMilliseconds);

            Console.ReadKey();

        }

        /// <summary>
        ///  Metoda buduje string
        /// </summary>
        /// <param name="ile">Podaj dlugosc petli</param>
        /// <returns>zwracamy gotowy tekst</returns>
        public static string budujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }
        public static string BudujStringBuilder(int ile)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0 ;i < ile; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }

    }
}
