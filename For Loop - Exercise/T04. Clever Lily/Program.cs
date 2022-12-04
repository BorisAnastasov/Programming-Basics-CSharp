using System;

namespace T04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int toyCounter = 0;
            int sumMoney = 0;
            int bigger = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sumMoney = sumMoney + bigger -1;
                    bigger += 10;
                }
                else
                {
                    toyCounter++;
                }
            }
            double sumAll = sumMoney + toyCounter * priceToy;
            if(sumAll >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(sumAll - priceWashingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWashingMachine - sumAll):f2}");
            }
        }
    }
}
