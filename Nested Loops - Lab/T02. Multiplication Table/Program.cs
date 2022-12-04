using System;

namespace T02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int b = 1; b <=10; b++)
                {
                    Console.WriteLine($"{i} * {b} = {i * b}");
                }
            }
        }
    }
}
