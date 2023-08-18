using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieFunkcji
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Multiply multiply = new Multiply();

            multiply.MultiplyNum(1, 2);
            multiply.MultiplyNum(3, 4, 5);
        }
    }
}
