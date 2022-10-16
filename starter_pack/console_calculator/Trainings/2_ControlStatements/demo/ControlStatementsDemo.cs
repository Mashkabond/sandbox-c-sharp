using System;

namespace control_statements
{
    internal class ControlStatementsDemo
    {
        static void Main(string[] args)
        {
            // we have two numbers
            int a = 1;
            int b = 2;

            // operations to check some condition
            bool greaterThen = a > b;           // false
            bool lessThen = a < b;              // true
            bool greaterThenOrEqual = a >= b;   // true
            bool lessThenOrEqual = a <= b;      // true
            bool equal = a == b;                // false

            // we have other two numbers
            int firstNumber = 10;
            int secondNumber = 20;

            // if statement
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("first number greater then second number");
            }

            // if else statement
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("first number greater then second number");
            }
            else
            {
                Console.WriteLine("first number less then second number or equal");
            }

            // if else statement with additional if
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("first number greater then second number");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("first number less then second number");
            }
            else
            {
                Console.WriteLine("first number equal to second number");
            }

            // || condition
            if (firstNumber > secondNumber || firstNumber == 10)
            {
                Console.WriteLine("first number greater then second number");
            }

            // && condition
            if (firstNumber < secondNumber && firstNumber == 10)
            {
                Console.WriteLine("first number greater then second number");
            }

            // scope for variables
            int x = 10;
            // int x = 10; // - compile error because x already exists
            if (x == 10)
            {
                // int x = 50; // - compile error because x already exists
                int z = 20;
            }
            else
            {
                int z = 30; // we can declare because z has different scope
            }

            // Functions
            int sum = GetSum(20, 30);

            // Functions with out variable
            int result = 0;
            TryParse("1", out result);
            Console.WriteLine(result);

            // switch statement
            string someText = "text";
            switch (someText) 
            {
                case "text":
                    Console.WriteLine("this is text");
                    break;
                case "text-2":
                    Console.WriteLine("this is text-2");
                    break;
                case "text-3":
                    Console.WriteLine("this is text-3");
                    break;
                default:
                    Console.WriteLine("this is default");
                    break;
            }
        }

        static int GetSum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        static bool TryParse(string text, out int result)
        {
            return int.TryParse(text, out result);
        }
    }
}
