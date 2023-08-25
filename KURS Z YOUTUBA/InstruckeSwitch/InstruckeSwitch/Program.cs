using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruckeSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int liczba;
            //liczba = int.Parse(Console.ReadLine());

            //// Liczba
            //if(liczba == 1)
            //{
            //    Console.WriteLine("Jeden");
            //}
            //else if(liczba == 2)
            //{
            //    Console.WriteLine("Dwa");
            //}
            //else if(liczba == 3)
            //{
            //    Console.WriteLine("Trzy");
            //}
            //else
            //{
            //    Console.WriteLine("Inna Wartosc");
            //}

            //switch (liczba)
            //{
            //    case 1:
            //        Console.WriteLine("Jeden");
            //        break;
            //    case 2:
            //        Console.WriteLine("Dwa");
            //        break;
            //    case 3:
            //        Console.WriteLine("Trzy");
            //        break;
            //    default:
            //        Console.WriteLine("Inna Wartosc");
            //        break;
            //}


            char znak = 'a';
            switch (znak)
            {
                case 'a':
                    Console.WriteLine("A");
                    goto koniec;
                case 'b':
                    Console.WriteLine("B");
                    goto case 'c';
                case 'c':
                    Console.WriteLine("C");
                    break;
                default:
                    Console.WriteLine("Inna Wartosc");
                    break;
            }

            //switch (liczba)
            //{
            //    case 1:
            //        Console.WriteLine("Jeden");
            //        goto koniec;
            //    case 2:
            //        Console.WriteLine("Dwa");
            //        break;
            //    case 3:
            //        Console.WriteLine("Trzy");
            //        break;
            //    default:
            //        Console.WriteLine("Inna Wartosc");
            //        break;
            //}
            Console.WriteLine("Jakis tekst");
        koniec:
            Console.WriteLine("Koniec");

            Console.ReadKey();
        }
    }
}
