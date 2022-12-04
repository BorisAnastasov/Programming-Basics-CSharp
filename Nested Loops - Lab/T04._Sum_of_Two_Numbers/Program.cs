using System;

namespace T04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int currRow = 0;
            bool magicNumber = false;
            for (int i = start; i <= end; i++)
            {
                for (int b = start; b <= end; b++)
                {
                    currRow++;
                    if (i + b == number)
                    {
                        magicNumber = true;
                        Console.WriteLine($"Combination N:{currRow} ({i} + {b} = {number})");
                        break;
                    }
                    if (magicNumber)
                    {
                        break;
                    }
                }
                if (magicNumber)
                {
                    break;
                }
            }
            if (magicNumber != true)
            {
                Console.WriteLine($"{currRow} combinations - neither equals {number}");
            }


        }
    }
}
