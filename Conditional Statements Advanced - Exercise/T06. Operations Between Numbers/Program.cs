using System;

namespace T06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());


            if(operation =='+' || operation =='-' || operation == '*')
            {
                int result;
                string evenOrOdd = "even";
                switch (operation)
                {
                    case '+':
                        result = num1+ num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    default:
                        result = num1 * num2;
                        break;
                }
                if(result%2 != 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else
            {
                if(num2 == 0)
                {
                    
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if(operation == '/')
                {
                    double result = 1.0 * num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else
                {

                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }
            }
        }
    }
}
