using System;

namespace T02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            for (int i = firstNum; i <= secondNumber; i++)
            {
                string currentNum = i.ToString();
                int sumEven = 0;
                int sumOdd = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if(j% 2 == 0)
                    {
                        sumEven += currentDigit;
                    }
                    else
                    {
                        sumOdd += currentDigit;
                    }
                }
                if(sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
