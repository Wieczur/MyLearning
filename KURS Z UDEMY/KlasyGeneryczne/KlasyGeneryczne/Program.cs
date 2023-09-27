using System;

namespace KlasyGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator<float>();

            Console.WriteLine("Wpisz prosze dwie liczby odzielone eneterem: ");

            var firstNumber = float.Parse(Console.ReadLine());
            var secoundNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Wpisz prosze dzialanie ktore chcesz wykonac");
            Console.WriteLine("Dostepne dzialania to: + - * /");

            var operation = Console.ReadLine();

            var result = default(float);

            switch (operation)
            {
                case "+":
                    {
                        result = calculator.Add(firstNumber, secoundNumber);

                    }
                    break;
                case "-":
                    {
                        result = calculator.Substract(firstNumber, secoundNumber);

                    }
                    break;
                case "*":
                    {
                        result = calculator.Multiplay(firstNumber, secoundNumber);

                    }
                    break;
                case "/":
                    {
                        result = calculator.Divide(firstNumber, secoundNumber);

                    }
                    break;


            }

            Console.WriteLine(result);
        }
    }
}
