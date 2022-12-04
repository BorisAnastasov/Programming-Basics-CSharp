using System;

namespace T02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
                
            }
            sum = sum - maxNumber;
            if(sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-maxNumber)}");
            }
        }
    }
}
