using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeWarunkoweIfElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instrukcje If

            int a = 4;
            
            if(a > 0 && a > 5)
            {
                Console.WriteLine("A jest wieksze od 0");
                Console.WriteLine("A jest wieksze od 5");                
            }
            else if (a > 0)
            {
                Console.WriteLine("A jest wieksze od 0");
            }
            else if(a == 0)
            {
                Console.WriteLine("A jest rowne 0");
            }
            else
            {
                Console.WriteLine("A jest mniejsza od 0");      
            }
            Console.ReadKey();


        }
    }
}
