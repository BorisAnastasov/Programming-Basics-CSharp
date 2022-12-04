using System;

namespace T10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evenSum += a;
                }
                else if(i % 2 != 0)
                {
                    oddSum += a;
                }
                    
            }
            if(evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else if(oddSum != evenSum)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)}");
            }
        }
    }
}
