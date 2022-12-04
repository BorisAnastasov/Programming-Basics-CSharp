using System;

namespace T09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;
            for (int i = 1; i <= n*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(i <= n)
                {
                    rightSum += number;
                }
                if(i > n)
                {
                    leftSum += number;
                }

            }
            if(rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else if(rightSum != leftSum)
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
