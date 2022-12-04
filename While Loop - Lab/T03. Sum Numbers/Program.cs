using System;

namespace T03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());
            int sumOfAllEnteredNumber = 0;
            while(targetNumber > sumOfAllEnteredNumber)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumOfAllEnteredNumber += inputNumber;
            }
            Console.WriteLine(sumOfAllEnteredNumber); 
        }
    }
}
