using System;

namespace T08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
                if(number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
