using System;

namespace T05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string row = Console.ReadLine();
            while(row != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double savedmoney = 0;
                while(neededMoney > savedmoney)
                {
                    savedmoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {row}!");
                row = Console.ReadLine();
            }
        }
    }
}
