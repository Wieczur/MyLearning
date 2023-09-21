using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieFunkcji
{
    public class Multiply
    {
       
        public int MultiplyNum(int number1, int number2)
        {
            return number1 * number2;           
        }
        public int MultiplyNum(int number1, int number2, int number3)
        {            
            return number1 * number2 * number3;           
        }
        public int MultiplyNum(int number1, int number2, int number3, int number4)
        {
            return number1 * number2 * number3 * number4;
        }
        public int MultiplyNum(int number5, double number6)
        {  
            return 0;
        }
        public string MultiplyNum(string number)
        {
            Console.WriteLine(number);
            return number;     
        }
    }
}






// Przeciazaniefunkcji, niech funkcja mnozy argumenty
