using System;

namespace KlasyGeneryczne
{
    class Calculator<T> 
    {
        public Calculator()
        {
            var example = default(T);
            var isInt = (example is int);
            var isFloat = (example is float);
            var isDouble = (example is double);

            if (isInt)
            {

            }
            else if (isFloat)
            {

            }
            else if (isDouble)
            {

            }
            else
            {
                Console.WriteLine("zainicjowano kalkulator niepoprawnie");
            }
        }

        public T Add(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber + secondNumber;
        }

        public T Substract(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber - secondNumber;
        }

        public T Multiplay(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber * secondNumber;
        }

        public T Divide(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber / secondNumber;
        }
    }
}
