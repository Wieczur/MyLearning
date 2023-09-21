using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        
        enum Priority
        {
            One = 1,
            Two,
            Three,
            Four,
            Five
        }
        static void Main(string[] args)
        {

            var priority = Priority.Three;
            Console.WriteLine(priority.ToString());
    
        /* enum Number
        {
            Even,
            Odd
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var numberType = (Number)(number % 2);           
            Console.WriteLine(numberType.ToString());
         */   

            /*
            if (reminder == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }
            */
            
        }   

    }
}
