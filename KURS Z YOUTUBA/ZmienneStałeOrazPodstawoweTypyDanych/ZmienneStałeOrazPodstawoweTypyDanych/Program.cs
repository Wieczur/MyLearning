using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmienneStałeOrazPodstawoweTypyDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STAŁA KTÓRA RAZ ZADEKLAROWANA NIE MOZE ZOSTAC ZMIENIONA
            const float PI = 3.14F; // const jest istotna zmiena ktora warto pamietac, sluzy do zachowania zmiennej przez caly okres dziala programu, nie da sie consta nadpisac

            //CAŁKOWITE
            sbyte zmienna1 = sbyte.MaxValue;
            byte zmienna2 = byte.MaxValue;
            short zmienna3 = short.MaxValue;
            ushort zmienna4 = 0;
            int zmienna5 = 5;
            uint zmienna6 = 0;
            long zmienna7 = long.MaxValue;
            ulong zmienna8 = 0;
            //ZMIENNO PRZECINKOWE
            float zmienna9 = 1.1324F;
            double zmienna10 = 8.12312313123;
            decimal zmienna11 = 9.12313123M;
            //ZNAKOWE
            string zmienna12 = "asdasdads";
            char zmienna13 = 'a';
            //LOGICZNE
            bool zmienna14 = false;
            bool zmienna15 = true;

            //Ciekawostka
            Console.WriteLine("Start");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Koniec");

        }
    }
}


/* 
 * git status
 * git add
 * git add . 
 * git commit -m "Komentarz"
 * git push origin master
 * git checkout -b "Nazwa Branch"
 */
